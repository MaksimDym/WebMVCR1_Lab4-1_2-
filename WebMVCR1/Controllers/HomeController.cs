﻿using Microsoft.AspNetCore.Mvc;
using WebMVCR1.Models;

namespace WebMVCR1.Controllers
{
    public class HomeController : Controller
    {
        public string  Index(string hel)
        {
            string Greeting = ModelClass.ModelHello() + ", " + hel;
            return Greeting;

        }


    }
}