﻿using Microsoft.AspNetCore.Mvc;
using primeraPagina.Models;
using System.Diagnostics;

namespace primeraPagina.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //ViewBag.Mensaje = "HOLA SOY ROBERTIÑO";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult MostrarMensaje() 
        {
            //ViewData["Mencion"] = "MostrarMensaje funciona correctamente";
            ViewData["Saludo"] = "MostrarMensaje funciona correctamente";
            return View("Index");
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}