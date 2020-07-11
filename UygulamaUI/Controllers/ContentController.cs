using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using UygulamaUI.Services.Data;
using System.Threading.Tasks;


namespace UygulamaUI.Controllers
{
    public class ContentController : Controller
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
    }
}