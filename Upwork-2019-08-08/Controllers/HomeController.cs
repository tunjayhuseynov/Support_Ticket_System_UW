using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Upwork_2019_08_08.Data;
using Upwork_2019_08_08.Models;
using Upwork_2019_08_08.Middleware;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

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
        public IActionResult Index()
        {
            string actionName = this.ControllerContext.RouteData.Values["action"].ToString();
            string controllerName = this.ControllerContext.RouteData.Values["controller"].ToString();

            ViewBag.url = "/" + controllerName + "/" + actionName+ "Raw";

            return View();
        }

        public IActionResult IndexRaw()
        {
            Task.Delay(500).Wait();
            return View();
        }

        public IActionResult FeedbackRaw()
        {
            Task.Delay(500).Wait();
           int? id = HttpContext.Session.GetInt32("LogedIn");
           List<Feedback> feedbacks = _context.Feedbacks.Where(w=> w.clientID == id).ToList();
            return View(feedbacks);
        }

        public IActionResult TicketRaw()
        {
            Task.Delay(500).Wait();
            int? id = HttpContext.Session.GetInt32("LogedIn");
            List<Ticket> tickets = _context.Tickets.OrderByDescending(w=>w.status).OrderByDescending(w=>w.status == 'n').Where(w => w.clientID == id).ToList();
         
            return View(tickets);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ViewTicket(int id)
        {
            List<string> names = new List<string>();
            List<Message> messages = _context.Messages.Include(w=>w.Ticket.Client).Where(w => w.ticketID == id).ToList();

            foreach (var item in messages)
            {
                if(item.from == true)
                {
                    names.Add(item.Ticket.Client.name);
                }
                else
                {
                    names.Add(_context.Admins.Where(w => w.id == item.fromID).FirstOrDefault().name);
                }
            }

            ViewBag.names = names;
            ViewBag.ticket = _context.Tickets.Where(w => w.id == id).FirstOrDefault();
            ViewBag.ClientName = _context.Clients.Where(w=> w.id == HttpContext.Session.GetInt32("LogedIn").GetValueOrDefault(0)).FirstOrDefault().name;

            if (HttpContext.Session.GetInt32("LogedIn").GetValueOrDefault(0) == _context.Tickets.Where(w=> w.id == id).FirstOrDefault().clientID)
            {
                return View(messages);
            }
            else
            {
                return Content("Session Is Over");
            }
        }


        [HttpPost]
        public IActionResult AddTicket(string subject, string text, List<IFormFile> files)
        {

            var filePaths = new List<string>();
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    // full path to file in temp location
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
                filename = filenameProcess,
                datetime = DateTime.Now,
                status = (char)Status.New,

            };

            _context.Tickets.Add(ticket);
            _context.SaveChanges();

            return Content("Done");
        }

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

        public IActionResult AddMessage(string subject, string text, List<IFormFile> files, int ticketid)
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
                subject = subject,
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

        public IActionResult getFeedbackMessage(int id)
        {

            return Content(_context.Feedbacks.Find(id).message);
        }

        public IActionResult deleteFeedbackMessage(int id)
        {
            if (_context.Feedbacks.Find(id).id == HttpContext.Session.GetInt32("LogedIn").GetValueOrDefault(0))
            {
                _context.Feedbacks.Remove(_context.Feedbacks.Find(id));
                _context.SaveChanges();
            }

            return Content("Done");
        }
    }
}
