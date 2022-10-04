using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ayakkabici.Models;
using DataAccess.Contexts;
using DataAccess.Entities;
using AppCore8137.DataAccess.Services;
using DataAccess.Servicess;
using Microsoft.EntityFrameworkCore;

namespace Ayakkabici.Controllers;

public class HomeController : Controller 
{
    private readonly Db db;
    
    

  
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, Db db)
    {
        _logger = logger;
        this.db = db;
       
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Ayakkabi()
    {
        
        List<Ayakkabi> ayakkabiList = db.Ayakkabilar.ToList();
        return View(ayakkabiList);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

