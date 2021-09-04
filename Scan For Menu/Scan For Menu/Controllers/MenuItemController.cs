using Microsoft.AspNetCore.Mvc;
using Scan_For_Menu.Data;
using Scan_For_Menu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scan_For_Menu.Controllers
{
    public class MenuItemController : Controller
    {


        private readonly ApplicationDbContext _dbContext;
       dynamic mymodel = new System.Dynamic.ExpandoObject();

        public MenuItemController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Menu()
        {
            IEnumerable<MenuItem> menuItemObj = _dbContext.MenuItem;
            IEnumerable<FoodCategory> categoyObj = _dbContext.FoodCategory;

            mymodel.MenuItem = menuItemObj;
            mymodel.FoodCategory = categoyObj;
            return View(mymodel);
        }

        //Get - Create
        public IActionResult Create()
        {
            IEnumerable<MenuItem> menuItemObj = _dbContext.MenuItem;
            IEnumerable<FoodCategory> categoyObj = _dbContext.FoodCategory;

            mymodel.MenuItem = menuItemObj;
            mymodel.FoodCategory = categoyObj;
            return View(mymodel);
        }
    }
}

