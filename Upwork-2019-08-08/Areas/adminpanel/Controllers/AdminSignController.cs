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
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using Upwork_2019_08_08.Middleware;
using Microsoft.Extensions.Options;

namespace Upwork_2019_08_08.Areas.adminpanel.Controllers
{
    [Area("AdminPanel")]
    public class AdminSignController : Controller
    {
        private readonly SystemContext _context;
        private ConfidentialInfo confidentialInfo { get; set; }

        public AdminSignController(SystemContext context, IOptions<ConfidentialInfo> setting)
        {
            _context = context;
            confidentialInfo = setting.Value;
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
            
            if (_context.AdminUsers.Where(w => w.email == email.Trim()).Count() > 0)
            {
                AdminUser admin = _context.AdminUsers.Where(w => w.email == email.Trim()).FirstOrDefault();

                if (Hash.Validate(password.Trim(), admin.token, admin.password))
                {
                    if(admin.isActive == false)
                    {
                        HttpContext.Session.SetInt32("inactive", 1);
                        return RedirectToAction("Index", "AdminSign");
                    }

                    HttpContext.Session.SetInt32("AdminLogedIn", admin.id);
                    HttpContext.Session.SetString("fullname", admin.name + " " + admin.surname);
                    if (admin.whoIs == 1)
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
            if (_context.AdminUsers.Where(w => w.email == email.Trim()).Count() > 0)
            {
                HttpContext.Session.SetInt32("Exist", 1);
                return RedirectToAction("SignUp", "AdminSign");
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
                whoIs = 1,
            };

            _context.AdminUsers.Add(admin);
            _context.SaveChanges();

            HttpContext.Session.SetInt32("AdminLogedIn", _context.AdminUsers.Where(w => w.email == email).FirstOrDefault().id);
            HttpContext.Session.SetString("fullname", admin.name + " " + admin.surname);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult GetEmailForPassword()
        {
            return View();
        }
        public IActionResult Reseting(string emailform)
        {
            if (_context.AdminUsers.Where(w => w.email == emailform).Any())
            {
                int id = _context.AdminUsers.Where(w => w.email == emailform).FirstOrDefault().id;
                string email = String.Empty;
                string token = String.Empty;

                email = _context.AdminUsers.Find(id).email;
                token = _context.AdminUsers.Find(id).token;



                string hostName = HttpContext.Request.Host.Host;
                int? port = HttpContext.Request.Host.Port;

           //     try
           //     {

                    string subject = "Reset Password";

                    string messageText = "<h1>Do Not Reply To This Mail Address!</h1> <h4>Link: </h4> <p>https://" + hostName + ":" + port + "/reset/index/" + id + "?token=" + token + "&who=" + 1 + "</p>";
                    SendMessage<String>("Support", messageText, email, subject);
/*                }
                catch (Exception)
                {


                }*/

                return Content("<h1 style='font-size: 50px;'>Check You E-mail</h1>", "text/html");
            }
            else
            {
                return Content("<h1 style='font-size: 50px;'>There is no such an email</h1>", "text/html");
            }
        }

        private void SendMessage<T>(string emailName, string messageText, string toEmail, string subject)
        {
            MimeMessage message = new MimeMessage();

            MailboxAddress from = new MailboxAddress(emailName,
            confidentialInfo.SupportEmail);
            message.From.Add(from);

            MailboxAddress to = new MailboxAddress("User",
            toEmail);

            message.To.Add(to);

            message.Subject = subject;

            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = messageText;


            message.Body = bodyBuilder.ToMessageBody();

            SmtpClient client = new SmtpClient();
            client.ServerCertificateValidationCallback = (s, c, ch, e) => true;
            client.Connect(confidentialInfo.SMTPemail, Convert.ToInt32(confidentialInfo.Port), SecureSocketOptions.SslOnConnect);
            client.Authenticate(confidentialInfo.SupportEmail, confidentialInfo.EmailPassword);

            client.Send(message);
            client.Disconnect(true);
            client.Dispose();
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