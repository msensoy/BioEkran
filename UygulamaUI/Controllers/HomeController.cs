using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using UygulamaUI.Models;
using UygulamaUI.Services.Data;

namespace UygulamaUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            
            string accessToken = HttpContext.Session.GetString("accesstoken");
            if (string.IsNullOrEmpty(accessToken))
            {
                return RedirectToAction("Index", "Login");
            }
            var apiService = new ApiServices();
            var devices = await apiService.GetDevicesForCurrentUserAsync(accessToken);
            //var devices = new List<Device>()
            //{
            //    new Device(){ Id= 123 , Name ="Computer" },
            //    new Device(){ Id= 456 , Name ="Phone"},
            //    new Device(){ Id= 789 , Name ="TV"}
            //};

            var selectlist = new SelectList(devices, "DeviceGUID", "DeviceGUID"); //value , name
            return View(selectlist);
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
