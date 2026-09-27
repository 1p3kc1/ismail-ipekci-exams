using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_CafeMenu.Models;

namespace MVC_CafeMenu.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var context = new CafeMenuDbContext();

        var menuItems = context.MenuItems.ToList();

        return View(menuItems);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
        });
    }
}