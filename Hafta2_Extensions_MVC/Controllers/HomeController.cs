using Hafta2_Extensions_MVC.CustomAttributes;
using Hafta2_Extensions_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Hafta2_Extensions_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Parametreleri yollayarak kullanıcının yetksini kontrol ediyoruz.
        // Bu attribute CustomAttributes klasörü içerisinde bulunuyor.
        [LoginFilter("lebronjames@gmail.com", "123")]
        public IActionResult Index()
        {
            return View();
        }

        // yetkili olmayan kullanıcı (Yani error sayfasına yönlendirilecek)
        [LoginFilter("jokerjokic@gmail.com", "789")] 
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
