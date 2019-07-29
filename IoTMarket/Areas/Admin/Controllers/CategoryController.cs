﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IoTMarket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IoTMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET
        public async Task<IActionResult> Index()
        {

            return View(await _db.Category.ToListAsync());
        }
    }
}