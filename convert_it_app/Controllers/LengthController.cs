using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace convert_it_app.Controllers
{
    public class LengthController : Controller
    {
        // 
        // GET: /Length/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /Length/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}

