using GITHUB_CORE_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GITHUB_CORE_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // eea: para probar el GIT
        private void MetodoBorrame() { 
            int ii = 0;
            ii = 1;
        
        
        }


        private void MetodoBorrame2()
        {
            int ii = 0;
            ii = 1;


        }

        private void MetodoBorrame3()
        {
            int ii = 0;
            string cadena = "";
            ii = 1;

            if (ii == 1)
            {
                cadena = "xxxxx";
            }
            else
            {
                cadena = "yyyyyyyyy";

            }


        }


    }
}
