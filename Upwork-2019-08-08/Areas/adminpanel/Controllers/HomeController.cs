using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Upwork_2019_08_08.Areas.adminpanel.Middleware;
using Upwork_2019_08_08.Data;
using Upwork_2019_08_08.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.IO;
using MailKit;
using MailKit.Net.Smtp;
using MimeKit;
using MailKit.Security;

namespace Upwork_2019_08_08.Areas.adminpanel.Controllers
{
    [Area("AdminPanel")]
    [AdminAuth]
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
            return View();
        }

        public IActionResult IndexRaw()
        {
            return View();
        }

        //
        //
        //
        // Log Out Route
        //
        //
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToRoute("Index", "AdminSign");
        }

        //
        //
        //
        // Ticket Route
        //
        //
        public IActionResult ViewTicket(int id)
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 0)
            {
                List<Ticket> tickets = new List<Ticket>();

                var DepartamentID = _context.AmAndDepartaments.Where(w => w.amID == HttpContext.Session.GetInt32("AdminLogedIn")).Select(i => i.departamentID).ToList();
                foreach (var item in DepartamentID)
                {
                    var ClientId = _context.DepartamentUsers.Where(w => w.departamentID == item).Select(i => i.clientID).ToList();

                    foreach (var iding in ClientId)
                    {
                        tickets.AddRange(_context.Tickets.Where(w => w.clientID == iding).ToList());
                    }
                }

                if (!tickets.Where(w=> w.id == id).Any())
                {
                    return Content("You do not have a permissoin for this ticket");
                }
            }
            List<string> names = new List<string>();
            List<Message> messages = _context.Messages.Include(i => i.Ticket.Client).Where(w => w.ticketID == id).OrderBy(a => a.datetime).ToList();

            foreach (var item in messages)
            {
                if (item.from == true)
                {
                    names.Add(item.Ticket.Client.name);
                }
                else
                {
                    names.Add(_context.Admins.Find(item.fromID).name);
                }
            }

            ViewBag.names = names;
            ViewBag.ticket = _context.Tickets.Find(id);
            ViewBag.department = _context.Tickets.Include(w => w.Department).Where(s => s.id == id).FirstOrDefault().Department.name;
            ViewBag.ClientName = _context.Tickets.Include(w => w.Client).Where(w => w.id == id).FirstOrDefault().Client.name + " " + _context.Tickets.Include(w => w.Client).Where(w => w.id == id).FirstOrDefault().Client.surname;

            if (HttpContext.Session.GetInt32("AdminLogedIn").GetValueOrDefault(-1) != -1)
            {
                return View(messages);
            }
            else
            {
                return Content("Session Is Over");
            }
        }

        public IActionResult AddMessage(string text, List<IFormFile> files, int ticketid)
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

            filePaths.ForEach(delegate (String s)
            {
                filenameProcess += (s + " ");
            });

            Message message = new Message
            {
                ticketID = ticketid,
                message = text,
                filename = filenameProcess,
                datetime = DateTime.Now,
                from = false,
                fromID = HttpContext.Session.GetInt32("AdminLogedIn").GetValueOrDefault()

            };


            if (_context.Messages.Where(w => w.ticketID == ticketid).ToList().Any() == false)
            {
                Ticket ticket = _context.Tickets.Find(ticketid);
                ticket.status = (char)Status.Pending;
                _context.Tickets.Update(ticket);
                _context.SaveChanges();

                string email = String.Empty;

                email = _context.Tickets.Include(w => w.Client).Where(a => a.id == ticketid).FirstOrDefault().Client.email;


                MimeMessage mailmessage = new MimeMessage();

                MailboxAddress from = new MailboxAddress("Talent Index",
                "admin@example.com");
                mailmessage.From.Add(from);

                MailboxAddress to = new MailboxAddress("User",
                email);

                mailmessage.To.Add(to);

                mailmessage.Subject = "The Ticket Is In Progress";

                BodyBuilder bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody = "<h1>Do Not Reply To This Mail Address!</h1> <h4>Link: </h4> <p> You ticket #" + ticketid + "  is in progress. Please, check your ticket</p>";


                mailmessage.Body = bodyBuilder.ToMessageBody();

                SmtpClient client = new SmtpClient();
                client.ServerCertificateValidationCallback = (s, c, ch, e) => true;
                client.Connect("smtp.gmail.com", 465, SecureSocketOptions.SslOnConnect);
                client.Authenticate("tuncayhuseynov@gmail.com", "5591980supertun");

                client.Send(mailmessage);
                client.Disconnect(true);
                client.Dispose();
            }
            _context.Messages.Add(message);
            _context.SaveChanges();

            return Content("Done");
        }

        public IActionResult TicketRaw()
        {
            List<Ticket> tickets = new List<Ticket>();
            Task.Delay(500).Wait();
            int? id = HttpContext.Session.GetInt32("isAdmin");
            if (id == 1)
            {
                tickets = _context.Tickets.OrderByDescending(w => w.status).OrderByDescending(w => w.status == 'n').ToList();
            }
            else if (id == 0)
            {

                var DepartamentID = _context.AmAndDepartaments.Where(w => w.amID == HttpContext.Session.GetInt32("AdminLogedIn")).Select(i => i.departamentID).ToList();
                foreach (var item in DepartamentID)
                {
                    var ClientId = _context.DepartamentUsers.Where(w => w.departamentID == item).Select(i => i.clientID).ToList();

                    foreach (var iding in ClientId)
                    {
                        tickets.AddRange(_context.Tickets.Where(w => w.clientID == iding).ToList());
                    }
                }
                tickets = tickets.OrderByDescending(w => w.status).OrderByDescending(w => w.status == 'n').ToList();
            }

            return View(tickets);
        }

        public IActionResult closeticket(int id)
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 0)
            {
                List<AmUser> list = _context.AmUsers.Where(w => w.AmID == HttpContext.Session.GetInt32("AdminLogedIn")).ToList();
                if (list.Any())
                {
                    if (list.Where(w => w.clientID == _context.Tickets.Find(id).clientID).Any())
                    {
                        Ticket ticket = _context.Tickets.Find(id);
                        ticket.status = 'c';
                        _context.Tickets.Update(ticket);
                        _context.SaveChanges();
                        return Content("Done");
                    }
                }
            }
            else if (HttpContext.Session.GetInt32("isAdmin") == 1)
            {
                Ticket ticket = _context.Tickets.Find(id);
                ticket.status = 'c';
                _context.Tickets.Update(ticket);
                _context.SaveChanges();
                return Content("Done");
            }

            return Content("Auth Failed");


        }

        /*
        public IActionResult FeedbackRaw()
        {
            List<Feedback> feedbacks = new List<Feedback>();
            Task.Delay(500).Wait();
            int? id = HttpContext.Session.GetInt32("isAdmin");
            if(id == 1)
            {
                 feedbacks = _context.Feedbacks.OrderByDescending(w=>w.datetime).ToList();

            }else if(id == 0)
            {
                List<int> ClientIDs = _context.AmAndClients.Where(w => w.amID == HttpContext.Session.GetInt32("AdminLogedIn").GetValueOrDefault(-1)).Select(i => i.departamentID).ToList();
                foreach (var item in ClientIDs)
                {
                    feedbacks.AddRange(_context.Feedbacks.Include(s=>s.Client).Where(w => w.Client.departmentID == item).ToList());
                }

            }
            return View(feedbacks);
        }*/



        //
        //
        //
        // Feedback Route
        //
        //
        public IActionResult FeedbackRaw()
        {
            Task.Delay(500).Wait();
            List<Feedback> feedbacks = _context.Feedbacks.OrderByDescending(w => w.datetime).ToList();
            return View(feedbacks);
        }

        public IActionResult getFeedbackMessage(int id)
        {

            return Content(_context.Feedbacks.Find(id).message);
        }

        public IActionResult deleteFeedbackMessage(int id)
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 1)
            {
                _context.Feedbacks.Remove(_context.Feedbacks.Find(id));
                _context.SaveChanges();
            }

            return Content("Done");
        }



        //
        //
        //
        // Admin User Route
        //
        //
        public IActionResult UsersRaw()
        {
            Task.Delay(500).Wait();
            List<Admin> admins = _context.Admins.OrderByDescending(w => w.isAdmin).ToList();
            ViewBag.departments = _context.Companies.ToList();

            return View(admins);
        }

        public IActionResult ViewUser(int id)
        {
            Admin admin = _context.Admins.Find(id);
            return View(admin);

        }

        public IActionResult EditUser(int id)
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 1)
            {
                Admin admin = _context.Admins.Find(id);
                return View(admin);
            }
            return Content("Auth Failed");

        }

        public IActionResult EditProcess(int UserId, string name, string surname, string email, int status)
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 1)
            {
                Admin admin = _context.Admins.Find(UserId);
                admin.name = name;
                admin.surname = surname;
                admin.email = email;
                admin.isAdmin = status == 1 ? true : false;
                _context.SaveChanges();
                return RedirectToAction("ViewUser", "Home", new { id = UserId });
            }
            return Content("Auth Failed");
        }

        public IActionResult DeleteUser(int id)
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 1)
            {
                _context.Admins.Remove(_context.Admins.Find(id));
                _context.SaveChanges();
                return Content("Done");
            }
            return Content("Auth Failed");

        }


        [HttpPost]
        public IActionResult AddAdminUser(string name, string surname, string email, string password, int role, int[] users)
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 1)
            {

                if (role == 0)
                {
                    if (users.Length == 0)
                    {
                        return Content("Empty User Error");
                    }
                }


                var salt = Salt.Create();
                var hash = Hash.Create(password.Trim(), salt);

                Admin admin = new Admin
                {
                    name = name,
                    surname = surname,
                    email = email.Trim(),
                    password = hash,
                    token = salt,
                    isAdmin = role == 1 ? true : false,
                };

                _context.Admins.Add(admin);
                _context.SaveChanges();


                if (users.Length > 0)
                {
                    List<AmAndDepartament> amAndClients = new List<AmAndDepartament>();
                    foreach (var item in users)
                    {
                        AmAndDepartament amAndClient = new AmAndDepartament()
                        {
                            amID = admin.id,
                            departamentID = item,
                            assignedTime = DateTime.Now,
                        };
                        amAndClients.Add(amAndClient);
                    }

                    _context.AmAndDepartaments.AddRange(amAndClients);
                    _context.SaveChanges();
                }


                return Content("Done");
            }
            return Content("Auth Failed");
        }



        //
        //
        //
        // Clients Route (Departments)
        //
        //

        public IActionResult ManageClients()
        {
            Task.Delay(500).Wait();
            List<Company> departaments = new List<Company>();

            if (HttpContext.Session.GetInt32("isAdmin") == 1)
            {
                departaments = _context.Companies.Include(w => w.DepartamentUser).ToList();
            }
            else if (HttpContext.Session.GetInt32("isAdmin") == 0)
            {
                departaments = _context.AmAndDepartaments.Include(w => w.Company).Where(s => s.amID == HttpContext.Session.GetInt32("AdminLogedIn").GetValueOrDefault()).Select(a => a.Company).Include(a => a.DepartamentUser).ToList();

            }

            return View(departaments);
        }


        public IActionResult AddClient(string name, string contact, string email, string address)
        {
            if (_context.Companies.Where(w => w.email == email.Trim()).Any())
            {
                return Content("Taken");
            }

            Company departament = new Company
            {
                name = name,
                contactperson = contact,
                address = address,
                email = email,
                isActive = true,
                createdDate = DateTime.Now,
                createdBy = HttpContext.Session.GetInt32("AdminLogedIn").GetValueOrDefault(),

            };

            _context.Companies.Add(departament);
            _context.SaveChanges();

            return Content("Done");
        }

        public IActionResult AddUser(string name, string surname, string email, string password, int[] users)
        {
            if(_context.Clients.Where(w=> w.email == email.Trim()).Any())
            {
                return Content("Taken");
            }

            if (HttpContext.Session.GetInt32("isAdmin") == 1)
            {
                var salt = Salt.Create();
                var hash = Hash.Create(password.Trim(), salt);

                Client client = new Client
                {
                    name = name,
                    surname = surname,
                    email = email,
                    password = hash,
                    token = salt,
                    isActive = true
                };

                _context.Clients.Add(client);
                _context.SaveChanges();

                foreach (var item in users)
                {
                    DepartamentUser departamentuser = new DepartamentUser
                    {
                        clientID = client.id,
                        departamentID = item,
                        assignedTime = DateTime.Now,
                    };
                    _context.DepartamentUsers.Add(departamentuser);
                    _context.SaveChanges();
                }
                return Content("Done");
            }

            return Content("Failed Auth");
        }

        public IActionResult ResetPassword(int id)
        {
            string email = String.Empty;
            string token = String.Empty;

            email = _context.Admins.Find(id).email;
            token = _context.Admins.Find(id).token;



            MimeMessage message = new MimeMessage();

            MailboxAddress from = new MailboxAddress("Talent Index",
            "admin@example.com");
            message.From.Add(from);

            MailboxAddress to = new MailboxAddress("User",
            email);

            message.To.Add(to);

            message.Subject = "Reset Password";

            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = "<h1>Do Not Reply To This Mail Address!</h1> <h4>Link: </h4> <p>https://localhost:44339/reset/index/" + id + "?token=" + token + "&who=" + 1 + "</p>";


            message.Body = bodyBuilder.ToMessageBody();

            SmtpClient client = new SmtpClient();
            client.ServerCertificateValidationCallback = (s, c, ch, e) => true;
            client.Connect("smtp.gmail.com", 465, SecureSocketOptions.SslOnConnect);
            client.Authenticate("tuncayhuseynov@gmail.com", "5591980supertun");

            client.Send(message);
            client.Disconnect(true);
            client.Dispose();

            return Content("Check You E-mail");
        }

        public IActionResult ViewClient(int id)
        {
            Company departament = _context.Companies.Find(id);
            return View(departament);
        }

        public IActionResult EditClient(int id)
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 0)
            {
                if(_context.AmUsers.Where(w=>w.AmID == HttpContext.Session.GetInt32("AdminLogedIn")).FirstOrDefault().DepartamentID != id)
                {
                    return Content("Auth Failed");
                }
                
            }


            Company departament = _context.Companies.Find(id);
            return View(departament);
        }

        public IActionResult deleteclient(int id)
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 0)
            {
                if (_context.AmUsers.Where(w => w.AmID == HttpContext.Session.GetInt32("AdminLogedIn")).FirstOrDefault().DepartamentID != id)
                {
                    return Content("Auth Failed");
                }
            }

            _context.Companies.Remove(_context.Companies.Find(id));
            _context.SaveChanges();

            return Content("Done");
        }

        public IActionResult EditClientProcess(int UserId, string name, string address, string contactperson, string email, int active)
        {
            Company departament = _context.Companies.Find(UserId);

            departament.name = name;
            departament.address = address;
            departament.contactperson = contactperson;
            departament.email = email;
            departament.isActive = active == 1 ? true : false;

            _context.Companies.Update(departament);
            _context.SaveChanges();

            return RedirectToAction("ViewClient","Home", new {  id= UserId});

        }

        public IActionResult ClientsUserPage(int id)
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 0)
            {
                List<Client> ClientId = new List<Client>();

                var DepartamentID = _context.AmAndDepartaments.Where(w => w.amID == HttpContext.Session.GetInt32("AdminLogedIn")).Select(i => i.departamentID).ToList();
                foreach (var item in DepartamentID)
                {
                    ClientId = _context.DepartamentUsers.Include(s=>s.Client).Where(w => w.departamentID == item).Select(i => i.Client).ToList();

                }

                if (!ClientId.Any())
                {
                    return Content("Auth Failed");
                }
            }

            List<Client> clients = _context.DepartamentUsers.Include(w => w.Client).Where(s => s.departamentID == id).Select(i=> i.Client).ToList();
            ViewBag.name = _context.Companies.Find(id).name;
            return View(clients);
        }

        public IActionResult Deleteclientuser(int id)
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 0)
            {
                if (!(_context.AmUsers.Where(w => w.AmID == HttpContext.Session.GetInt32("AdminLogedIn")).Where(s => s.clientID == id).Any()))
                {
                    return Content("Auth Failed");
                }
            }

            Client client = _context.Clients.Find(id);
            _context.Clients.Remove(client);
            _context.SaveChanges();

            return Content("Done");
        }

        public IActionResult EditClientUser(int id)
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 0)
            {
                if (!(_context.AmUsers.Where(w => w.AmID == HttpContext.Session.GetInt32("AdminLogedIn")).Where(s => s.clientID == id).Any()))
                {
                    return Content("Auth Failed");
                }
            }

            
            return View(_context.Clients.Find(id));
        }

        public IActionResult EditClientUserProcess(string name, string surname, string email, int active, int UserId)
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 0)
            {
                if (!(_context.AmUsers.Where(w => w.AmID == HttpContext.Session.GetInt32("AdminLogedIn")).Where(s => s.clientID == UserId).Any()))
                {
                    return Content("Auth Failed");
                }
            }

            Client client = _context.Clients.Find(UserId);
            client.name = name;
            client.surname = surname;
            client.email = email;
            client.isActive = active == 1 ? true : false;
            _context.Clients.Update(client);
            _context.SaveChanges();

            return RedirectToAction("ViewClientUser", "Home", new { id = UserId });
        }

        public IActionResult ViewClientUser(int id)
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 0)
            {
                if (!(_context.AmUsers.Where(w => w.AmID == HttpContext.Session.GetInt32("AdminLogedIn")).Where(s => s.clientID == id).Any()))
                {
                    return Content("Auth Failed");
                }
            }
            return View(_context.Clients.Find(id));
        }
    }
}