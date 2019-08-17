using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Upwork_2019_08_08.Data;
using Upwork_2019_08_08.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Text;
using System.Security.Cryptography;

namespace Upwork_2019_08_08.Areas.adminpanel.Controllers
{
    [Area("AdminPanel")]
    public class AdminSignController : Controller
    {
        private readonly SystemContext _context;

        public AdminSignController(SystemContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult SignInProcess(string email, string password, string remember)
        {
            if (_context.Admins.Where(w => w.email == email.Trim()).Count() > 0)
            {
                Admin admin = _context.Admins.Where(w => w.email == email.Trim()).FirstOrDefault();

                if (Hash.Validate(password.Trim(), admin.token, admin.password))
                {
                    HttpContext.Session.SetInt32("AdminLogedIn", admin.id);
                    if (admin.isAdmin)
                    {
                        HttpContext.Session.SetInt32("isAdmin", 1);
                    }
                    else
                    {
                        HttpContext.Session.SetInt32("isAdmin", 0);
                    }

                    return RedirectToAction("Index", "Home");
                }

            }

            HttpContext.Session.SetInt32("AuthFailed", 1);

            return RedirectToAction("Index", "AdminSign");
        }

        public IActionResult SignUpProcess(string name, string surname, string email, string password)
        {
            if (_context.Admins.Where(w => w.email == email.Trim()).Count() > 0)
            {
                HttpContext.Session.SetInt32("Exist", 1);
                return RedirectToAction("SignUp", "AdminSign");
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
                isAdmin = true,
            };

            _context.Admins.Add(admin);
            _context.SaveChanges();

            HttpContext.Session.SetInt32("AdminLogedIn", _context.Admins.Where(w => w.email == email).FirstOrDefault().id);

            return RedirectToAction("Index", "Home");
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