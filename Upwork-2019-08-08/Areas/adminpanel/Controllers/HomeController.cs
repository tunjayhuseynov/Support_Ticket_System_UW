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

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToRoute("Index","AdminSign");
        }

          public IActionResult ViewTicket(int id)
          {
              if(HttpContext.Session.GetInt32("isAdmin") == 0)
            {
                int clId = _context.Tickets.Find(id).clientID;
                if(_context.AmUsers.Where(w=> w.clientID == clId && w.AmID == HttpContext.Session.GetInt32("AdminLogedIn")).Count() == 0){
                    return Content("You do not have a permissoin for this ticket");
                }
            }
              List<string> names = new List<string>();
              List<Message> messages = _context.Messages.Include(i=> i.Ticket.Client).Where(w => w.ticketID == id).OrderBy(a=> a.datetime).ToList();

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
              ViewBag.department = _context.Tickets.Include(w => w.Departament).Where(s => s.id == id).FirstOrDefault().Departament.name;
              ViewBag.ClientName = _context.Tickets.Include(w => w.Client).Where(w => w.id == id).FirstOrDefault().Client.name +" "+  _context.Tickets.Include(w => w.Client).Where(w => w.id == id).FirstOrDefault().Client.surname;

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

            filePaths.ForEach(delegate (String s) {

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

            _context.Messages.Add(message);
            _context.SaveChanges();
            return Content("Done");
        }

        public IActionResult TicketRaw()
        {
            List<Ticket> tickets = new List<Ticket>();
            Task.Delay(500).Wait();
            int? id = HttpContext.Session.GetInt32("isAdmin");
            if(id == 1)
            {
                 tickets = _context.Tickets.OrderByDescending(w=>w.status).OrderByDescending(w => w.status == 'n').ToList();
            }
            else if(id == 0)
            {
                /*
                List<int> ClientIDs = _context.AmAndClients.Where(w => w.amID == HttpContext.Session.GetInt32("AdminLogedIn").GetValueOrDefault(-1)).Select(i => i.departamentID).ToList();
                foreach (var item in ClientIDs)
                {
                    tickets.AddRange(_context.Tickets.Include(s=>s.Client).Where(w => w.Client.departmentID == item).ToList());
                }*/

                /*   List<int> ClientId = new List<int>();

                   foreach (var item in _context.AmAndClients.Where(w => w.amID == HttpContext.Session.GetInt32("AdminLogedIn")).Select(i => i.departamentID).ToList())
                   {
                       ClientId.AddRange(_context.DepartamentUsers.Where(w => w.departamentID == item).Select(i => i.clientID).ToList());

                   }

                   foreach (var item in ClientId)
                   {
                       tickets.AddRange(_context.Tickets.Where(w => w.clientID == item).ToList());
                   }*/

                
                var ClientId = _context.AmUsers.Where(w => w.AmID == HttpContext.Session.GetInt32("AdminLogedIn")).GroupBy(d=>d.clientID).Select(i => i.Key);
                foreach (var item in ClientId)
                {
                    tickets.AddRange(_context.Tickets.Where(w => w.clientID == item).ToList());
                }
            }

            return View(tickets);
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

        public IActionResult FeedbackRaw()
        {
            Task.Delay(500).Wait();
            List<Feedback> feedbacks = _context.Feedbacks.OrderByDescending(w => w.datetime).ToList();
            return View(feedbacks);
        }

        public IActionResult UsersRaw()
        {
            Task.Delay(500).Wait();
            List<Admin> admins = _context.Admins.OrderByDescending(w=>w.isAdmin).ToList();
            ViewBag.departments = _context.Departaments.ToList();

            return View(admins);
        }

        public IActionResult ViewUser(int id)
        {

                Admin admin = _context.Admins.Find(id);
                return View(admin);


        }

        public IActionResult EditUser(int id)
        {
            if(HttpContext.Session.GetInt32("isAdmin") == 1)
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
                admin.isAdmin = status==1?true:false;
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

        public IActionResult ResetPassword()
        {
            return View();
        }


        public IActionResult getFeedbackMessage(int id)
        {
           
            return Content(_context.Feedbacks.Find(id).message);
        }

        public IActionResult deleteFeedbackMessage(int id)
        {
            if(HttpContext.Session.GetInt32("isAdmin") == 1)
            {
                _context.Feedbacks.Remove(_context.Feedbacks.Find(id));
                _context.SaveChanges();
            }

            return Content("Done");
        }

        [HttpPost]
        public IActionResult AddUser(string name, string surname, string email, string password, int role, int[] users)
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

        public IActionResult ManageClients()
        {
            Task.Delay(500);
            List<Departament> departaments = new List<Departament>();

            if (HttpContext.Session.GetInt32("isAdmin") == 1)
            {
                 departaments = _context.Departaments.Include(w=>w.DepartamentUser).ToList();
            }else if(HttpContext.Session.GetInt32("isAdmin") == 0)
            {
                departaments = _context.AmAndDepartaments.Include(w => w.Departament).Where(s => s.amID == HttpContext.Session.GetInt32("AdminLogedIn").GetValueOrDefault()).Select(a => a.Departament).Include(a=>a.DepartamentUser).ToList();
               
            }

            return View(departaments);
        }


        public IActionResult AddClient(string name)
        {
            Departament departament = new Departament
            {
                name = name,
            };

            _context.Departaments.Add(departament);
            _context.SaveChanges();

            return Content("Done");
        }

        public IActionResult AddUser(string name, string surname, string email, string password, int[] users)
        {
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
                    token = salt
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
    }


}