﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GrapePhoto.Controllers
{
    public class FollowersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}