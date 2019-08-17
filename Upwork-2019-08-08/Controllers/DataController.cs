using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Upwork_2019_08_08.Data;
using Upwork_2019_08_08.Middleware;
using Upwork_2019_08_08.Models;

namespace Upwork_2019_08_08.Controllers
{
    [Auth]
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly SystemContext _context;
        private IHostingEnvironment _env;
        public DataController(SystemContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;

        }
        public ActionResult<List<Feedback>> Feedbacks()
        {
            return _context.Feedbacks.Where(w=>w.clientID == HttpContext.Session.GetInt32("LogedIn").GetValueOrDefault(0)).ToList();
        }
    }
}