using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Interns_Gate.Models;

namespace Interns_Gate.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    // test github
    public HomeController(ILogger<HomeController> logger)
    {

        int i = 0;
        _logger = logger;
    }

    public IActionResult Index()
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

