﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GrapePhoto.Models;
using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Authentication.Cookies;

namespace GrapePhoto.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
    
        public IActionResult Index()
        {
            return View();
        }

      

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
