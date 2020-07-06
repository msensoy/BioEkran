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
        string _accessToken = "";
        ApiServices _apiService = new ApiServices();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            _accessToken = HttpContext.Session.GetString("accesstoken");
            if (string.IsNullOrEmpty(_accessToken))
            {
                return RedirectToAction("Index", "Login");
            }
            var devices = await _apiService.GetDevicesForCurrentUserAsync(_accessToken);
            
            if (devices == null)
            {
                devices = new List<Device>();
            }
            var selectlist = new SelectList(devices, "Id", "Name"); 
            return View(selectlist);
        }


        public async Task<JsonResult> DeviceName(int id)
        {
            _accessToken = HttpContext.Session.GetString("accesstoken");
            var devices = await _apiService.GetDevicesForCurrentUserAsync(_accessToken);
            var device = devices.Where(x => x.Id == id).FirstOrDefault();
            return Json(device);
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
