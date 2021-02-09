using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Exceptions.Models;

namespace Exceptions.Controllers
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
            //throw new ArgumentOutOfRangeException();
            return View();
        }

        public IActionResult CheckException(int num)
        {
            if (num == 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (num == 2)
            {
                throw new AccessViolationException();
            }
            if (num == 3)
            {
                throw new ArithmeticException();
            }
            if (num == 4)
            {
                throw new DivideByZeroException();
            }
            if (num == 5)
            {
                throw new MissingFieldException();
            }
            if (num == 6)
            {
                throw new FormatException();
            }
            if (num == 7)
            {
                throw new InvalidOperationException();
            }
            if (num == 8)
            {
                throw new StackOverflowException();
            }
            if (num == 9)
            {
                throw new ArgumentException();
            }
            return RedirectToAction("Privacy");
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
    }
}
