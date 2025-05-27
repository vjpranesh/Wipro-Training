using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication12.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}