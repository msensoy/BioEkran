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
            return View(selectlist);
        }

        public Chart GetChart(List<double?> valueList, List<string> stringList, string title, ChartColor color)
        {
            Chart chart = new Chart();

            chart.Type = Enums.ChartType.Line;

            ChartJSCore.Models.Data data = new ChartJSCore.Models.Data();
            data.Labels = stringList;

            LineDataset dataset = new LineDataset()
            {
                Label = title,
                Data = valueList,
                Fill = "false",
                LineTension = 0.1,
                BackgroundColor = color,
                BorderColor = color,
                BorderCapStyle = "butt",
                BorderDash = new List<int> { },
                BorderDashOffset = 0.0,
                BorderJoinStyle = "miter",
                PointBorderColor = new List<ChartColor> { color },
                PointBackgroundColor = new List<ChartColor> { ChartColor.FromHexString("#ffffff") },
                PointBorderWidth = new List<int> { 1 },
                PointHoverRadius = new List<int> { 5 },
                PointHoverBackgroundColor = new List<ChartColor> { color },
                PointHoverBorderColor = new List<ChartColor> { color },
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

            return Json(device);
        }

        [Route("Home/GetCharts/{deviceId}")]
        public async Task<IActionResult> GetCharts(int deviceId)
        {

            if (deviceId == 0)
            {
                var valueList0 = new List<double?>() { 0, 0, 0, 0, 0 };
                var stringList0 = new List<string>() { "", "", "", "", "" };
                Charts = new List<Chart>() { GetChart(valueList0, stringList0, "Sensör Verileri", new ChartColor() { Red = 72, Green = 192, Blue = 192, Alpha = 0.4 }) };
                return View();
            }
            Charts = new List<Chart>();
            _accessToken = HttpContext.Session.GetString("accesstoken");
            var sensorDataList = await _apiService.SearchDevicesAsync(deviceId, _accessToken);
            var sensorTypeList = await _apiService.GetSensorTypesAsync(_accessToken);
            var colorListForCharts = new List<ChartColor>()
            {
                new ChartColor()
                {
                    Alpha = 0.4,
                    Red = 72,
                    Green = 192,
                    Blue =192
                },
                new ChartColor()
                {
                    Alpha = 0.4,
                    Red = 222,
                    Green = 22,
                    Blue =22
                }
                ,
                new ChartColor()
                {
                    Alpha = 0.4,
                    Red = 22,
                    Green = 222,
                    Blue =22
                },
                new ChartColor()
                {
                    Alpha = 0.4,
                    Red = 22,
                    Green = 22,
                    Blue =222
                }
            };
            for (int i = 0; i < sensorTypeList.Count; i++)
            {
                var sensorName = sensorTypeList[i].Name;
                var dataList = sensorDataList.Where(x => x.TypeId == sensorTypeList[i].Id);

                var groupDataList = dataList.Skip(6).Select(x => new { sValue = x.Value, sTime = DateTime.Parse(x.Time) }).GroupBy(x => x.sTime.Day).ToList();
                var valueList = groupDataList.Select(x => x.Average(z => z.sValue)).ToList();
                var stringList = (groupDataList.Select(x => (x.First().sTime.Date.Date).ToString("dd MMMM yyyy"))).ToList();
                var colorIndex = i % (colorListForCharts.Count());

                var color = colorListForCharts[colorIndex];
                var Chart = GetChart(valueList, stringList, sensorName, color);
                Charts.Add(Chart);
            }

            return View();
        }

        [ViewData]
        public List<Chart> Charts { get; set; }
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
