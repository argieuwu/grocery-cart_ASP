﻿using Microsoft.AspNetCore.Mvc;

namespace GeoceriCart.Controllers
{
    public class AuthPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}