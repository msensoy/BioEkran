using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UygulamaUI.Models;
using UygulamaUI.Services.Data;

namespace UygulamaUI.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var token = HttpContext.Session.GetString("accesstoken");
            if (!string.IsNullOrEmpty(token))
            {
                HttpContext.Session.SetString("accesstoken", "");
            }
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(RegisterBindingModel user)
        {

            var apiService = new ApiServices();
            var token = await apiService.LoginAsync(user.Email, user.Password);
            if (token != null)
            {
                HttpContext.Session.SetString("accesstoken", token);

                return RedirectToAction("Index", "Home");
            }
            ViewData["Hata"] = "Lütfen giriş bilgilerinizi kontrol ediniz";
            return View();
        }

    }
}