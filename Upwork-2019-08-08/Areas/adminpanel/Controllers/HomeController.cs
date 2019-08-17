﻿using System.Collections.Generic;
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

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToRoute("Index","AdminSign");
        }

          public IActionResult ViewTicket(int id)
          {
              if(HttpContext.Session.GetInt32("isAdmin") == 0)
            {
                if(_context.AmAndClients.Where(w=> w.clientID == _context.Tickets.Find(id).clientID).Count() == 0){
                    return Content("You do not have a permissoin for this ticket");
                }
            }
              List<string> names = new List<string>();
              List<Message> messages = _context.Messages.Include(i=> i.Ticket.Client).Where(w => w.ticketID == id).ToList();

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
              ViewBag.ClientName = _context.Tickets.Include(w => w.Client).Where(w => w.id == id).FirstOrDefault().Client.name;

              if (HttpContext.Session.GetInt32("AdminLogedIn").GetValueOrDefault(-1) != -1)
              {
                  return View(messages);
              }
              else
              {
                  return Content("Session Is Over");
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
                List<int> ClientIDs = _context.AmAndClients.Where(w => w.amID == HttpContext.Session.GetInt32("AdminLogedIn").GetValueOrDefault(-1)).Select(i => i.clientID).ToList();
                foreach (var item in ClientIDs)
                {
                    tickets.AddRange(_context.Tickets.Where(w => w.clientID == item).ToList());
                }

            }

            return View(tickets);
        }


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
                List<int> ClientIDs = _context.AmAndClients.Where(w => w.amID == HttpContext.Session.GetInt32("AdminLogedIn").GetValueOrDefault(-1)).Select(i => i.clientID).ToList();
                foreach (var item in ClientIDs)
                {
                    feedbacks.AddRange(_context.Feedbacks.Where(w => w.clientID == item).ToList());
                }

            }
            return View(feedbacks);
        }

        public IActionResult UsersRaw()
        {
            Task.Delay(500).Wait();
            List<Admin> admins = _context.Admins.OrderByDescending(w=>w.isAdmin).ToList();

            return View(admins);
        }

        public IActionResult ViewUser(int id)
        {
            if(HttpContext.Session.GetInt32("isAdmin") == 1)
            {
                Admin admin = _context.Admins.Find(id);
                return View(admin);
            }

            return Content("Auth Failed");
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

        public IActionResult AddUser()
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 1)
            {
                
                return Content("Done");
            }
            return Content("Auth Failed");
        }
    }
}