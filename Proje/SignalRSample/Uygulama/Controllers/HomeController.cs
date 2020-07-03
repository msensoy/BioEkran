using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Uygulama.Models;
using Uygulama.Services.Data;

namespace Uygulama.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login()
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

        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            
            var apiService = new ApiServices();
            var token = await apiService.LoginAsync(user.Email, user.Password);
            if (token !=null)
            {
                HttpContext.Session.SetString("accesstoken", token);

                return RedirectToAction("Index", "MainScreen");
            }
            ViewData["Hata"] = "Lütfen giriş bilgilerinizi kontrol ediniz";
            return View();
        }
    }
}
