using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Upwork_2019_08_08.Data;
using Upwork_2019_08_08.Models;

namespace Upwork_2019_08_08.Controllers
{
    public class ResetController : Controller
    {
        private readonly SystemContext _context;
        private IHostingEnvironment _env;

        public ResetController(SystemContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;

        }
        public IActionResult Index(int id, string token, int who)
        {
            token = token.Replace(" ", "+");
            if(who == 0)
            {
                if(_context.Clients.Find(id).token != token)
                {
                    return Content("Auth Failed");
                }
            }
            else if(who == 1)
            {
                if (_context.Admins.Find(id).token != token)
                {
                    return Content("Auth Failed");
                }
            }

            ViewBag.id = id;
            ViewBag.who = who;
            ViewBag.token = token;

            return View();
        }

        public IActionResult ComplateReset(int userid, int who, string token, string password, string again)
        {
            token = token.Replace(" ", "+");
            if (who == 0)
            {
                if (_context.Clients.Find(userid).token == token)
                {
                    var salt = Salt.Create();
                    var hash = Hash.Create(password, salt);

                    Client client = _context.Clients.Find(userid);
                    client.password = hash;
                    client.token = salt;
                    _context.Clients.Update(client);
                    _context.SaveChanges();
                }
            }
            else if (who == 1)
            {
                if (_context.Admins.Find(userid).token == token)
                {
                    var salt = Salt.Create();
                    var hash = Hash.Create(password, salt);

                    Admin admin = _context.Admins.Find(userid);
                    admin.password = hash;
                    admin.token = salt;
                    _context.Admins.Update(admin);
                    _context.SaveChanges();
                }
            }

            return RedirectToAction("Index", "Sign");
        }
    }
}