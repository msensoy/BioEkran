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
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(RegisterBindingModel user)
        {

            if (ModelState.IsValid)
            {
                var apiService = new ApiServices();
                var token = await apiService.RegisterUserAsync(user.Email, user.PhoneNumber, user.Password, user.Password);
                if (!string.IsNullOrEmpty(token))
                {
                    HttpContext.Session.SetString("accesstoken", token);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
    }
}