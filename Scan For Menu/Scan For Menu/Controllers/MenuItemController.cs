﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Scan_For_Menu.Data;
using Scan_For_Menu.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Scan_For_Menu.Controllers
{
    public class MenuItemController : Controller
    {


        private readonly ApplicationDbContext _dbContext;
       dynamic mymodel = new ExpandoObject();
        static CustomerOrder GetCart = new CustomerOrder();

        public MenuItemController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        
        public IActionResult Menu(CustomerOrder obj)
        {
            HttpContext.Session.SetString("tableNum", obj.TableNr.ToString());
            IEnumerable<MenuItem> menuItemObj = _dbContext.MenuItem;
            IEnumerable<FoodCategory> categoyObj = _dbContext.FoodCategory;
          

            mymodel.MenuItem = menuItemObj;
            mymodel.FoodCategory = categoyObj;
            mymodel.CustomerOrder = obj;
            return View(mymodel);
        }




   
        /*
      [HttpPost]
      [ValidateAntiForgeryToken]
        public IActionResult Table(CustomerOrder obj)
        {
            mymodel.CustomerOrder = obj; 
            return Menu();
        }
        */
    }
}

