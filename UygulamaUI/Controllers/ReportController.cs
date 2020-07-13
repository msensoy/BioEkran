using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using UygulamaUI.Models;
using UygulamaUI.Services.Data;
using ChartJSCore.Models;
using ChartJSCore.Helpers;

namespace UygulamaUI.Controllers
{
    public class ReportController : Controller
    {
        string _accessToken = "";
        ApiServices _apiService = new ApiServices();
        public async Task<IActionResult> Index()
        {
            _accessToken = HttpContext.Session.GetString("accesstoken");
            if (string.IsNullOrEmpty(_accessToken))
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
        public Chart GetChart(ChartDataSet chartDataSets)
        {
            Chart chart = new Chart();

            chart.Type = Enums.ChartType.Line;

            ChartJSCore.Models.Data data = new ChartJSCore.Models.Data();

            data.Datasets = new List<Dataset>();


            data.Labels = chartDataSets.XValues;

            LineDataset dataset = new LineDataset()
            {
                Label = chartDataSets.Title,
                Data = chartDataSets.YValues.Select(x => (double?)Math.Round(x.Value, 2)).ToList(),
                Fill = "false",
                LineTension = 0.1,
                BackgroundColor = chartDataSets.Color,
                BorderColor = chartDataSets.Color,
                BorderCapStyle = "butt",
                BorderDash = new List<int> { },
                BorderDashOffset = 0.0,
                BorderJoinStyle = "miter",
                PointBorderColor = new List<ChartColor> { chartDataSets.Color },
                PointBackgroundColor = new List<ChartColor> { ChartColor.FromHexString("#ffffff") },
                PointBorderWidth = new List<int> { 1 },
                PointHoverRadius = new List<int> { 5 },
                PointHoverBackgroundColor = new List<ChartColor> { chartDataSets.Color },
                PointHoverBorderColor = new List<ChartColor> { chartDataSets.Color },
                PointHoverBorderWidth = new List<int> { 2 },
                PointRadius = new List<int> { 1 },
                PointHitRadius = new List<int> { 10 },
                SpanGaps = false
            };
            data.Datasets.Add(dataset);


            chart.Data = data;
            return chart;
        }

        public async Task<JsonResult> GetDeviceInfo(int id)
        {
            _accessToken = HttpContext.Session.GetString("accesstoken");
            var apiService = new ApiServices();
            var devices = await _apiService.GetDevicesForCurrentUserAsync(_accessToken);
            var device = devices.Where(x => x.Id == id).FirstOrDefault();

            var sensorDataList = await _apiService.SearchDevicesAsync(device.Id, _accessToken);
            var pHLevel = sensorDataList.Where(x => x.TypeId == 1).Select(x => Math.Round(((double)x.Value),1)).LastOrDefault(); // Ph için 1
            var result = new { Device = device, PHLevel = pHLevel };
            return Json(result);



        }

        [Route("Report/GetCharts/{deviceId}")]
        public async Task<IActionResult> GetCharts(int deviceId)
        {
            _accessToken = HttpContext.Session.GetString("accesstoken");
            var colorClass = new ColorsSet();
            var colorListForCharts = colorClass.Colors;
            if (deviceId == 0)
            {
                var valueList0 = new List<double?>() { 0, 0, 0, 0, 0 };
                var stringList0 = new List<string>() { "", "", "", "", "" };
                var dataSets0 = new ChartDataSet("Sensör Verileri", colorListForCharts[0], valueList0, stringList0);
                Charts = new List<Chart>() { GetChart(dataSets0) };
                return View();
            }
            Charts = new List<Chart>();
            var apiService = new ApiServices();
            var sensorDataList = await _apiService.SearchDevicesAsync(deviceId, _accessToken);
            var sensorTypeList = await _apiService.GetSensorTypesAsync(_accessToken);



            for (int i = 0; i < sensorTypeList.Count; i++)
            {

                var sensorName = sensorTypeList[i].Name;
                var dataList = sensorDataList.Where(x => x.TypeId == sensorTypeList[i].Id);

                var groupDataList = dataList.Skip(6).Select(x => new { sValue = x.Value, sTime = DateTime.Parse(x.Time) }).GroupBy(x => x.sTime.Day).ToList();
                var valueList = groupDataList.Select(x => x.Average(z => z.sValue)).ToList();
                var stringList = (groupDataList.Select(x => (x.First().sTime.Date.Date).ToString("dd.MM.yyyy"))).ToList();
                var colorIndex = i % (colorListForCharts.Count());

                var color = colorListForCharts[colorIndex];

                var datasets = new ChartDataSet(sensorName, color, valueList, stringList);
                var chart = GetChart(datasets);
                Charts.Add(chart);
                break;
            }
            return View();
        }


        [ViewData]
        public List<Chart> Charts { get; set; }
    }
}