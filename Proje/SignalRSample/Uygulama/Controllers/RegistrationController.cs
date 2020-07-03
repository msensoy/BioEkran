using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uygulama.Services.Data;
using Microsoft.AspNetCore.Mvc;
using Uygulama.Models;
using Microsoft.AspNetCore.Http;

namespace Uygulama.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(User user)
        {
            if (ModelState.IsValid)
            {
                var apiService = new ApiServices();
                var token = await apiService.RegisterUserAsync(user.Email, user.PhoneNumber, user.Password, user.Password);
                if (!string.IsNullOrEmpty(token))
                {
                    HttpContext.Session.SetString("accesstoken", token);
                    return RedirectToAction("Index", "MainScreen");
                }
            }
            else
            {
                ViewData["Hata"] = "Lütfen boş bırakmayınız";
            }
            return View("Index");
        }
    }
}