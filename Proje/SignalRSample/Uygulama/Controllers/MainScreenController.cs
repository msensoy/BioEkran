using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uygulama.Services.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Uygulama.Models;
using Microsoft.AspNetCore.Http;

namespace Uygulama.Controllers
{
    public class MainScreenController : Controller
    {
        List<Device> devices;
        public async Task<IActionResult> Index()
        {

            string accessToken = HttpContext.Session.GetString("accesstoken");
            var apiService = new ApiServices();
            devices = await apiService.GetDevicesForCurrentUserAsync(accessToken);
            return View(devices);
        }
        int topla(int a)
        {
            a--;
            return a + topla(a);
        }
    }
}