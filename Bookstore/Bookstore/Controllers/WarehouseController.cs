﻿using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    public class WarehouseController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }

    }
}