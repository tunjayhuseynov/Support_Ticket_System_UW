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

                List<int?> DepartamentID = _context.AmAndDepartaments.Where(w => w.amID == HttpContext.Session.GetInt32("AdminLogedIn")).Select(i => i.departamentID).ToList();

                if (!DepartamentID.Contains(_context.Tickets.Include(w => w.ClientUser).FirstOrDefault().ClientUser.companyID))
                {
                    return Content("You do not have a permissoin for this ticket");

                }

            }
            List<string> names = new List<string>();
            List<Message> messages = _context.Messages.Include(i => i.Ticket.ClientUser).Where(w => w.ticketID == id).OrderBy(a => a.datetime).ToList();

            foreach (var item in messages)
            {
                if (item.from == true)
                {
                    names.Add(item.Ticket.ClientUser.name);
                }
                else
                {
                    names.Add(_context.AdminUsers.Find(item.fromID).name);
                }
            }

            ViewBag.names = names;
            ViewBag.ticket = _context.Tickets.Find(id);
            ViewBag.department = _context.Tickets.Include(w => w.Department).Where(s => s.id == id).FirstOrDefault().Department.name;
            ViewBag.ClientName = _context.Tickets.Include(w => w.ClientUser).Where(w => w.id == id).FirstOrDefault().ClientUser.name + " " + _context.Tickets.Include(w => w.ClientUser).Where(w => w.id == id).FirstOrDefault().ClientUser.surname;

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

                email = _context.Tickets.Include(w => w.ClientUser).Where(a => a.id == ticketid).FirstOrDefault().ClientUser.email;


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
                tickets = _context.Tickets.Include(s=>s.ClientUser.Company).OrderByDescending(w => w.status).OrderByDescending(w => w.status == 'n').ToList();
            }
            else if (id == 0)
            {

                List<int?> DepartamentID = _context.AmAndDepartaments.Where(w => w.amID == HttpContext.Session.GetInt32("AdminLogedIn")).Select(i => i.departamentID).ToList();

                foreach (var item in DepartamentID)
                {
                    tickets.AddRange(_context.Tickets.Include(s => s.ClientUser.Company).Where(w => w.ClientUser.companyID == item).ToList());
                }
                tickets = tickets.OrderByDescending(w => w.status).OrderByDescending(w => w.status == 'n').ToList();
            }

            return View(tickets.Where(w=>w.isDeleted != true).ToList());
        }

        public IActionResult closeticket(int id)
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 0)
            {
                List<Ticket> tickets = new List<Ticket>();
                List<int> ClientId = new List<int>();

                var DepartamentID = _context.AmAndDepartaments.Where(w => w.amID == HttpContext.Session.GetInt32("AdminLogedIn")).Select(i => i.departamentID).ToList();

                if (!DepartamentID.Contains(_context.Tickets.Include(w => w.ClientUser).FirstOrDefault().ClientUser.companyID))
                {
                    return Content("You do not have a permissoin for this ticket");

                }

            }

            Ticket ticket = _context.Tickets.Find(id);
            ticket.status = 'c';
            _context.Tickets.Update(ticket);
            _context.SaveChanges();
            return Content("Done");

        }


        //
        //
        //
        // Feedback Route
        //
        //
        public IActionResult FeedbackRaw()
        {
            Task.Delay(500).Wait();
            List<Feedback> feedbacks = _context.Feedbacks.Where(s=>s.isDeleted != true).OrderByDescending(w => w.datetime).ToList();
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
                Feedback feedback = _context.Feedbacks.Find(id);
                feedback.isDeleted = true;
                _context.Feedbacks.Update(feedback);
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
            List<AdminUser> admins = _context.AdminUsers.Include(s=>s.AdminRole).OrderByDescending(w => w.AdminRole.name).ToList();
            ViewBag.departments = _context.Companies.ToList();

            return View(admins);
        }

        public IActionResult ViewUser(int id)
        {
            AdminUser admin = _context.AdminUsers.Find(id);
            return View(admin);

        }

        public IActionResult EditUser(int id)
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 1)
            {
                AdminUser admin = _context.AdminUsers.Find(id);
                return View(admin);
            }
            return Content("Auth Failed");

        }

        public IActionResult EditProcess(int UserId, string name, string surname, string email, int status)
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 1)
            {
                AdminUser admin = _context.AdminUsers.Find(UserId);
                admin.name = name;
                admin.surname = surname;
                admin.email = email;
                admin.whoIs = status == 1 ? 1 : 2;
                _context.SaveChanges();
                return RedirectToAction("ViewUser", "Home", new { id = UserId });
            }
            return Content("Auth Failed");
        }

        public IActionResult DeleteUser(int id)
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 1)
            {
                AdminUser adminUser = _context.AdminUsers.Find(id);
                adminUser.isDelete = true;
                _context.AdminUsers.Update(adminUser);
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

                AdminUser admin = new AdminUser
                {
                    name = name,
                    surname = surname,
                    email = email.Trim(),
                    password = hash,
                    token = salt,
                    whoIs = role == 1 ? 1 : 2,
                };

                _context.AdminUsers.Add(admin);
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
                departaments = _context.Companies.Include(w => w.ClientUsers).Where(s=>s.isDeleted != true).ToList();
            }
            else if (HttpContext.Session.GetInt32("isAdmin") == 0)
            {
                departaments = _context.AmAndDepartaments.Include(w => w.Company).Where(s => s.amID == HttpContext.Session.GetInt32("AdminLogedIn").GetValueOrDefault()).Select(a => a.Company).Include(a => a.ClientUsers).Where(s=>s.isDeleted != true).ToList();

            }

            return View(departaments.Where(w=> w.isDeleted != true).ToList());
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

        public IActionResult AddUser(string name, string surname, string email, string password, int users)
        {
            if (_context.ClientUsers.Where(w => w.email == email.Trim()).Any())
            {
                return Content("Taken");
            }

            if (HttpContext.Session.GetInt32("isAdmin") == 1)
            {
                var salt = Salt.Create();
                var hash = Hash.Create(password.Trim(), salt);

                ClientUser client = new ClientUser
                {
                    name = name,
                    surname = surname,
                    email = email,
                    password = hash,
                    token = salt,
                    isActive = true,
                    companyID = users,
                };

                _context.ClientUsers.Add(client);
                _context.SaveChanges();


                return Content("Done");
            }

            return Content("Failed Auth");
        }

        public IActionResult ResetPassword(int id)
        {
            string email = String.Empty;
            string token = String.Empty;

            email = _context.AdminUsers.Find(id).email;
            token = _context.AdminUsers.Find(id).token;



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
                return Content("Auth Failed");
            }

            Company departament = _context.Companies.Find(id);
            return View(departament);
        }

        public IActionResult deleteclient(int id)
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 0)
            {
                return Content("Auth Failed");

            }

            Company company = _context.Companies.Find(id);
            company.isDeleted = true;
            _context.Companies.Update(company);
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

            return RedirectToAction("ViewClient", "Home", new { id = UserId });

        }

        public IActionResult ClientsUserPage(int id)
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 0)
            {
                List<ClientUser> ClientId = new List<ClientUser>();

                var DepartamentID = _context.AmAndDepartaments.Where(w => w.amID == HttpContext.Session.GetInt32("AdminLogedIn")).Select(i => i.departamentID).ToList();

               
                if (!DepartamentID.Contains(id))
                {
                    return Content("Auth Failed");
                }
            }

            List<ClientUser> clients = _context.ClientUsers.Where(w => w.companyID == id).ToList();
            ViewBag.name = _context.Companies.Find(id).name;
            ViewBag.id = id;
            return View(clients.Where(w=>w.isDeleted != true).ToList());
        }

        public IActionResult Deleteclientuser(int id)
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 0)
            {

                return Content("Auth Failed");

            }

            ClientUser client = _context.ClientUsers.Find(id);
            client.isDeleted = true;
            _context.ClientUsers.Update(client);
            _context.SaveChanges();

            return Content("Done");
        }

        public IActionResult EditClientUser(int id)
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 0)
            {
                return Content("Auth Failed");

            }


            return View(_context.ClientUsers.Find(id));
        }

        public IActionResult EditClientUserProcess(string name, string surname, string email, int active, int UserId)
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 0)
            {

                return Content("Auth Failed");

            }

            ClientUser client = _context.ClientUsers.Find(UserId);
            client.name = name;
            client.surname = surname;
            client.email = email;
            client.isActive = active == 1 ? true : false;
            _context.ClientUsers.Update(client);
            _context.SaveChanges();

            return RedirectToAction("ViewClientUser", "Home", new { id = UserId });
        }

        public IActionResult ViewClientUser(int id)
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 0)
            {
                List<int?> DepartamentID = _context.AmAndDepartaments.Where(w => w.amID == HttpContext.Session.GetInt32("AdminLogedIn")).Select(i => i.departamentID).ToList();

                if (!DepartamentID.Contains(_context.ClientUsers.Find(id).companyID))
                {
                    return Content("Auth Failed");
                }
            }
            return View(_context.ClientUsers.Find(id));
        }


        //
        //
        //
        //
        // Log History
        //
        ///
        //
        //
        //
        public IActionResult LogHistory()
        {
            return View();
        }

        //
        //
        //
        //Profile

        public IActionResult Profile(int id)
        {
           

            return View(_context.AdminUsers.Find(id));
        }



        //
        //
        //
        // Change Activation of User

        public IActionResult ChangeActivationUser(int id)
        {
            ClientUser client = _context.ClientUsers.Find(id);

            client.isActive = client.isActive==true?false:true;

            _context.ClientUsers.Update(client);
            _context.SaveChanges();

            return Content("Done");
        }

        public IActionResult ChangeActivationClient(int id)
        {
            Company company = _context.Companies.Find(id);
            List<ClientUser> users = _context.ClientUsers.Where(w => w.companyID == id).ToList();
            users.ForEach(delegate (ClientUser user)
            {
                user.isActive = company.isActive==true?false:true;
                _context.ClientUsers.Update(user);
            });
            company.isActive = company.isActive==true?false:true;

            _context.Companies.Update(company);
            
            _context.SaveChanges();

            return Content("Done");
        }

        public IActionResult ChangeActivationAdmin(int id)
        {
            AdminUser admin = _context.AdminUsers.Find(id);
            admin.isActive = admin.isActive==true?false:true;

            _context.AdminUsers.Update(admin);
            _context.SaveChanges();
            return Content("Done");
        }


    }
}