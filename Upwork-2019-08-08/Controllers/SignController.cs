using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Upwork_2019_08_08.Data;
using Upwork_2019_08_08.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Text;
using System.Security.Cryptography;

namespace Upwork_2019_08_08.Controllers
{
    public class SignController : Controller
    {
        private readonly SystemContext _context;

        public enum LogStatus
        {
            In = 'i',
            Out = 'o',
        }
        public SignController(SystemContext context)
        {
            _context = context;

        }

        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult SignInProcess(string email, string password, string remember)
        {
            if(_context.Clients.Where(w=> w.email == email.Trim()).Count() > 0)
            {
                Client client = _context.Clients.Where(w => w.email == email.Trim()).FirstOrDefault();

                if (Hash.Validate(password.Trim(), client.token, client.password))
                {
                    HttpContext.Session.SetInt32("LogedIn", client.id);

                    LogHistorie logHistorie = new LogHistorie
                    {
                        clientID = client.id,
                        date = DateTime.Now,
                        logStatus = (char)LogStatus.In,
                    };
                    _context.LogHistories.Add(logHistorie);
                    _context.SaveChanges();

                    return RedirectToAction("Index", "Home");
                }
                
            }

            HttpContext.Session.SetInt32("AuthFailed", 1);

            return RedirectToAction("Index", "Sign");
        }

        public IActionResult SignUp()
        {
            List<Departament> departaments = _context.Departaments.ToList();
            return View(departaments);
        }

        [HttpPost]
        public IActionResult SignUpProcess(string name, string surname, string email, string password, int departmentID)
        {
            if(_context.Clients.Where(w=> w.email == email.Trim()).Count() > 0)
            {
                HttpContext.Session.SetInt32("Exist", 1);
                return RedirectToAction("SignUp", "Sign");
            }
            var salt = Salt.Create();
            var hash = Hash.Create(password.Trim(), salt);

            Client client = new Client
            {
                name = name,
                surname = surname,
                email = email.Trim(),
                departmentID = departmentID,
                password = hash,
                token = salt
            };

            _context.Clients.Add(client);
            _context.SaveChanges();

            HttpContext.Session.SetInt32("LogedIn", _context.Clients.Where(w => w.email == email).FirstOrDefault().id);

            return RedirectToAction("Index","Home");
        }


    }

    public class Hash
    {
        public static string Create(string value, string salt)
        {
            var valueBytes = KeyDerivation.Pbkdf2(
                                password: value,
                                salt: Encoding.UTF8.GetBytes(salt),
                                prf: KeyDerivationPrf.HMACSHA512,
                                iterationCount: 10000,
                                numBytesRequested: 256 / 8);

            return Convert.ToBase64String(valueBytes);
        }

        public static bool Validate(string value, string salt, string hash)
            => Create(value, salt) == hash;
    }

    public class Salt
    {
        public static string Create()
        {
            byte[] randomBytes = new byte[128 / 8];
            using (var generator = RandomNumberGenerator.Create())
            {
                generator.GetBytes(randomBytes);
                return Convert.ToBase64String(randomBytes);
            }
        }
    }
}