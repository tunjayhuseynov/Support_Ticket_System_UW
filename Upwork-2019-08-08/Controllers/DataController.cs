using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Upwork_2019_08_08.Data;
using System.Linq;
using System.Linq.Dynamic.Core;
using Upwork_2019_08_08.Middleware;
using Upwork_2019_08_08.Models;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Upwork_2019_08_08.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DataController : Controller
    {
        private readonly SystemContext _context;
        private IHostingEnvironment _env;
        public DataController(SystemContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;

        }
        [HttpPost]
        
        public IActionResult Logs()
        {
            if(HttpContext.Session.GetInt32("AdminLogedIn").GetValueOrDefault(0) == 0)
            {
                return Json(new { Result = "Auth Failed" });
            }
            var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
            // Skiping number of Rows count  
            var start = Request.Form["start"].FirstOrDefault();
            // Paging Length 10,20  
            var length = Request.Form["length"].FirstOrDefault();
            // Sort Column Name  
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            // Sort Column Direction ( asc ,desc)  
            var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
            // Search Value from (Search box)  
            var searchValue = Request.Form["search[value]"].FirstOrDefault();


            //Paging Size (10,20,50,100)    
            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;
            int recordsTotal = 0;

            // Getting all Customer data    
            var customerData = (from tempcustomer in _context.LogHistories.Include(w=>w.Client)
                                select tempcustomer);

            //Sorting    
            if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
            {
                customerData = customerData.OrderBy(sortColumn + " " + sortColumnDirection);
            }
            //Search    
            if (!string.IsNullOrEmpty(searchValue))
            {
                customerData = customerData.Where(m => m.Client.name == searchValue);
            }

            //total number of rows count     
            recordsTotal = customerData.Count();
            //Paging     
            var data = customerData.Skip(skip).Take(pageSize).ToList();

            return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });
        }
    }
}