using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlayWithDI.IServices;
using PlayWithDI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PlayWithDI.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private readonly IAqiService aqiService;

    public HomeController(ILogger<HomeController> logger, IAqiService aqiService)
    {
      _logger = logger;
      this.aqiService = aqiService;
    }

    public IActionResult Index(string city = "Bangkok")
    {
      ViewBag.AQI = aqiService.GetAQI(city, DateTime.Now);
      ViewBag.City = "Japan";
      return View();
    }

    public IActionResult Contactus()
    {
      return View();
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
