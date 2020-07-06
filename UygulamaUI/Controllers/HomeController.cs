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
using ChartJSCore.Models;
using ChartJSCore.Helpers;

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

            var chart = GetChart(new List<double?>() { 30, 20, 10, 40, 50, 20, 70 });
            ViewData["chart"] = chart;

            return View(selectlist);
        }

        public Chart GetChart(List<double?> list)
        {
            Chart chart = new Chart();

            chart.Type = Enums.ChartType.Line;

            ChartJSCore.Models.Data data = new ChartJSCore.Models.Data();
            data.Labels = new List<string>() { "January", "February", "March", "April", "May", "June", "July" };

            LineDataset dataset = new LineDataset()
            {
                Label = "Sensör Verileri",
                Data = list,
                Fill = "false",
                LineTension = 0.1,
                BackgroundColor = ChartColor.FromRgba(75, 192, 192, 0.4),
                BorderColor = ChartColor.FromRgb(75, 192, 192),
                BorderCapStyle = "butt",
                BorderDash = new List<int> { },
                BorderDashOffset = 0.0,
                BorderJoinStyle = "miter",
                PointBorderColor = new List<ChartColor> { ChartColor.FromRgb(75, 192, 192) },
                PointBackgroundColor = new List<ChartColor> { ChartColor.FromHexString("#ffffff") },
                PointBorderWidth = new List<int> { 1 },
                PointHoverRadius = new List<int> { 5 },
                PointHoverBackgroundColor = new List<ChartColor> { ChartColor.FromRgb(75, 192, 192) },
                PointHoverBorderColor = new List<ChartColor> { ChartColor.FromRgb(220, 220, 220) },
                PointHoverBorderWidth = new List<int> { 2 },
                PointRadius = new List<int> { 1 },
                PointHitRadius = new List<int> { 10 },
                SpanGaps = false
            };

            data.Datasets = new List<Dataset>();
            data.Datasets.Add(dataset);

            chart.Data = data;

            return chart;
        }

        public async Task<JsonResult> GetDeviceInfo(int id)
        {
            _accessToken = HttpContext.Session.GetString("accesstoken");
            var devices = await _apiService.GetDevicesForCurrentUserAsync(_accessToken);
            var device = devices.Where(x => x.Id == id).FirstOrDefault();
            var chart = GetChart(new List<double?>() { 10, 20, 30, 40, 50, 60, 70 });
            ViewData["chart"] = chart;
            return Json(device);
        }
        public async Task<JsonResult> GetDeviceSensorInfo(int deviceId)
        {
            _accessToken = HttpContext.Session.GetString("accesstoken");
            var sensorDataList = await _apiService.SearchDevicesAsync(deviceId, _accessToken);
            return Json(sensorDataList.Skip(7));
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
