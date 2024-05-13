﻿using Microsoft.AspNetCore.Mvc;

namespace ChatServer.Areas.Chat.Controllers
{
    [Area("Chat")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
