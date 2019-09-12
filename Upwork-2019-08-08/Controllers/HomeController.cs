using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Dynamic.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Upwork_2019_08_08.Data;
using Upwork_2019_08_08.Models;
using Upwork_2019_08_08.Middleware;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;

namespace Upwork_2019_08_08.Controllers
{
    [Auth]
    public class HomeController : Controller
    {
        private string filenameProcess;

        enum Status
        {
            New = 'n',
            Pending = 'p',
            Closed = 'c'
        }


        private readonly SystemContext _context;
        private IHostingEnvironment _env;

        public HomeController(SystemContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;

        }

        /* INDEX MENU */
        public IActionResult Index()
        {
            string actionName = this.ControllerContext.RouteData.Values["action"].ToString();
            string controllerName = this.ControllerContext.RouteData.Values["controller"].ToString();

            ViewBag.url = "/" + controllerName + "/" + actionName+ "Raw";

            return View();
        }

        /* INDEX MENU */
        public IActionResult IndexRaw()
        {
            Task.Delay(500).Wait();
            return View();
        }



        /* FEEDBACK MENU */
        public IActionResult FeedbackRaw()
        {
            Task.Delay(500).Wait();
           int? id = HttpContext.Session.GetInt32("LogedIn");
           List<Feedback> feedbacks = _context.Feedbacks.Where(w=> w.clientID == id).ToList();
            return View(feedbacks);
        }


        /*  TICKET MENU  */
        public IActionResult TicketRaw()
        {
            Task.Delay(500).Wait();
            int? id = HttpContext.Session.GetInt32("LogedIn");
            List<Ticket> tickets = _context.Tickets.OrderByDescending(w=>w.status).OrderByDescending(w=>w.status == 'n').Where(w => w.clientID == id).ToList();
            ViewBag.department = _context.Departments.ToList();
            return View(tickets);
        }

        public IActionResult Privacy()
        {
            return View();
        }


        /* VIEW A TICKET PAGE */
        public IActionResult ViewTicket(int id)
        {
            List<string> names = new List<string>();
            List<Message> messages = _context.Messages.Include(w=>w.Ticket.ClientUser).Where(w => w.ticketID == id).ToList();

            foreach (var item in messages)
            {
                if(item.from == true)
                {
                    names.Add(item.Ticket.ClientUser.name);
                }
                else
                {
                    names.Add(_context.AdminUsers.Where(w => w.id == item.fromID).FirstOrDefault().name);
                }
            }

            ViewBag.names = names;
            ViewBag.ticket = _context.Tickets.Where(w => w.id == id).FirstOrDefault();
            ViewBag.ClientName = _context.ClientUsers.Where(w=> w.id == HttpContext.Session.GetInt32("LogedIn").GetValueOrDefault(0)).FirstOrDefault().name;
            ViewBag.department = _context.Tickets.Include(w=>w.Department).Where(s=>s.id == id).FirstOrDefault().Department.name;

            if (HttpContext.Session.GetInt32("LogedIn").GetValueOrDefault(0) == _context.Tickets.Where(w=> w.id == id).FirstOrDefault().clientID)
            {
                return View(messages);
            }
            else
            {
                return Content("Session Is Over");
            }
        }



        /*  ADD TICKET PROCESS  */
        [HttpPost]
        public IActionResult AddTicket(string subject, string text, int departament, List<IFormFile> files)
        {

            var filePaths = new List<string>();
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    
                    string Filename = DateTime.Now.ToString("yyyyMMddHHmmssffff") + formFile.FileName.Replace(" ","");
                    var path = Path.Combine(_env.WebRootPath, "files/"+Filename);
                    filePaths.Add(path.Trim());

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        formFile.CopyTo(stream);
                    }
                }
            }

            filePaths.ForEach(delegate (String s) {

                filenameProcess += (s + " ");
            });

            Ticket ticket = new Ticket
            {
                clientID = HttpContext.Session.GetInt32("LogedIn").GetValueOrDefault(0),
                subject = subject,
                message = text,
                departmentID = departament,
                filename = filenameProcess,
                datetime = DateTime.Now,
                status = (char)Status.New,

            };

            _context.Tickets.Add(ticket);
            _context.SaveChanges();



            var email = _context.ClientUsers.Find(HttpContext.Session.GetInt32("LogedIn").GetValueOrDefault(0)).email;


            MimeMessage mailmessage = new MimeMessage();

            MailboxAddress from = new MailboxAddress("Talent Index",
            "admin@example.com");
            mailmessage.From.Add(from);

            MailboxAddress to = new MailboxAddress("User",
            email);

            mailmessage.To.Add(to);

            mailmessage.Subject = "Ticket is created";

            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = "<h1>Do Not Reply To This Mail Address!</h1> <h4> You ticket #" + ticket.id + "  is created. You can check your ticket</h4>";


            mailmessage.Body = bodyBuilder.ToMessageBody();

            SmtpClient client = new SmtpClient();
            client.ServerCertificateValidationCallback = (s, c, ch, e) => true;
            client.Connect("smtp.gmail.com", 465, SecureSocketOptions.SslOnConnect);
            client.Authenticate("tuncayhuseynov@gmail.com", "5591980supertuncay");

            client.Send(mailmessage);
            client.Disconnect(true);
            client.Dispose();

            return Content(ticket.id.ToString());
        }


        /*  CLOSE A TICKET PROCESS  */
        public IActionResult CloseTicket(int id)
        {
            try
            {
                var ticket = _context.Tickets.Where(w => w.id == id && w.clientID == HttpContext.Session.GetInt32("LogedIn")).FirstOrDefault();

                ticket.status = (char)Status.Closed;
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return Content("Session is over");
            }

        }


        /*  ADD A MESSAGE PROCESS   */
        public IActionResult AddMessage( string text, List<IFormFile> files, int ticketid)
        {
            var filePaths = new List<string>();
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    // full path to file in temp location
                    string Filename = DateTime.Now.ToString("yyyyMMddHHmmssffff") + formFile.FileName.Replace(" ", "");
                    var path = Path.Combine(_env.WebRootPath, "files/" + Filename);
                    filePaths.Add(path.Trim());

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        formFile.CopyTo(stream);
                    }
                }
            }

            filePaths.ForEach(delegate (String s) {

                filenameProcess += (s + " ");
            });

            Message message = new Message
            {
                ticketID = ticketid,
                message = text,
                filename = filenameProcess,
                datetime = DateTime.Now,
                from = true,
                fromID = HttpContext.Session.GetInt32("LogedIn").GetValueOrDefault()

            };

            _context.Messages.Add(message);
            _context.SaveChanges();

            return Content("Done");
        }


        /*   ADD A FEEDBACK PROCESS   */
        [HttpPost]
        public IActionResult AddFeedback(string name, string email, string text, string subject)
        {
            Feedback feedback = new Feedback
            {
                clientID = HttpContext.Session.GetInt32("LogedIn").GetValueOrDefault(0),
                datetime = DateTime.Now,
                message = text,
                name = name,
                email = email,
                subject = subject
            };

            _context.Feedbacks.Add(feedback);
            _context.SaveChanges();

            return Content("Done");
        }


        /*  LOG OUT PROCESS  */
        public IActionResult LogOut()
        {
            LogHistorie logHistorie = new LogHistorie
            {
                clientID = HttpContext.Session.GetInt32("LogedIn").GetValueOrDefault(0),
                date = DateTime.Now,
                logStatus = (char)SignController.LogStatus.Out,
            };
            _context.LogHistories.Add(logHistorie);
            _context.SaveChanges();

            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Sign");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        /*  AJAX GET FEEDBACK MESSAGE  */
        public IActionResult getFeedbackMessage(int id)
        {

            return Content(_context.Feedbacks.Find(id).message);
        }


        /*  AJAX DELETE FEEDBACK MESSAGE  */
        public IActionResult deleteFeedbackMessage(int id)
        {
            if (_context.Feedbacks.Find(id).id == HttpContext.Session.GetInt32("LogedIn").GetValueOrDefault(0))
            {
                _context.Feedbacks.Remove(_context.Feedbacks.Find(id));
                _context.SaveChanges();
            }

            return Content("Done");
        }


        public IActionResult ResetPassword(int id)
        {
            string email = String.Empty;
            string token = String.Empty;

            email = _context.ClientUsers.Find(id).email;
            token = _context.ClientUsers.Find(id).token;



            MimeMessage message = new MimeMessage();

            MailboxAddress from = new MailboxAddress("Talent Index",
            "admin@example.com");
            message.From.Add(from);

            MailboxAddress to = new MailboxAddress("User",
            email);

            message.To.Add(to);

            message.Subject = "Reset Password";

            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = "<h1>Do Not Reply To This Mail Address!</h1> <h4>Link: </h4> <p>https://localhost:44339/reset/index/" + id + "?token=" + token + "&who=" + 0 + "</p>";


            message.Body = bodyBuilder.ToMessageBody();

            SmtpClient client = new SmtpClient();
            client.ServerCertificateValidationCallback = (s, c, ch, e) => true;
            client.Connect("smtp.gmail.com", 465, SecureSocketOptions.SslOnConnect);
            client.Authenticate("tuncayhuseynov@gmail.com", "5591980supertuncay");

            client.Send(message);
            client.Disconnect(true);
            client.Dispose();

            return Content("Check You E-mail");
        }

        public IActionResult Profile(int id)
        {


            return View(_context.ClientUsers.Find(id));
        }


        public IActionResult ServiceRequests()
        {
            List<ServiceRequest> requests = _context.ServiceRequests.Include(w=>w.Responses).Where(w => w.clientUserId == HttpContext.Session.GetInt32("LogedIn").GetValueOrDefault(0)).ToList();
            ViewBag.type = _context.ServiceTypes.ToList();

            foreach (var item in requests.Where(w => w.status == 'n').ToList())
            {
                if (_context.Responses.Select(s => s.serviceRequestId).ToList().Contains(item.id))
                {
                    item.status = (char)Status.Closed;
                    _context.ServiceRequests.Update(item);
                    _context.SaveChanges();
                }
            }

            return View(requests);
        }

        [HttpPost]
        public IActionResult AddServiceRequest(string[] ids, int[] types)
        {
            ServiceRequest service = new ServiceRequest
            {
                clientUserId = HttpContext.Session.GetInt32("LogedIn").GetValueOrDefault(0),
                createdTime = DateTime.Now,
                status = (char)Status.New,
                noOfIds = ids.Count(),
            };

            _context.ServiceRequests.Add(service);
            _context.SaveChanges();

            List<Detail> details = new List<Detail>();

            for (int i = 0; i < ids.Count(); i++)
            {
                Detail detail = new Detail
                {
                    idNumber = ids[i],
                    serviceRequestId = service.id,
                    serviceTypeId = types[i]
                };
                details.Add(detail);

            }

            _context.Details.AddRange(details);
            _context.SaveChanges();

            return Content(service.id.ToString());
        }

        public IActionResult GetDetails(int id)
        {
            List<ServiceRequest> services = _context.ServiceRequests.Where(w => w.id == id).ToList();
            List<Detail> details = new List<Detail>();

            foreach (var item in services)
            {
                details.AddRange(_context.Details.Include(s=>s.serviceType).Where(w => w.serviceRequestId == item.id).ToList());
            }
            return Json(new { number = details.Select(w=>w.idNumber), servicename = details.Select(w=>w.serviceType.name) });
        }


    }
}
