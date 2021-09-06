using Microsoft.AspNetCore.Mvc;
using Scan_For_Menu.Data;
using Scan_For_Menu.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Scan_For_Menu.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        dynamic mymodel = new ExpandoObject();

        public AdminController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult ViewItems()
        {
            IEnumerable<MenuItem> menuItemObj = _dbContext.MenuItem;
            IEnumerable<FoodCategory> categoyObj = _dbContext.FoodCategory;

            mymodel.MenuItem = menuItemObj;
            mymodel.FoodCategory = categoyObj;
            return View(mymodel);
        }
    }
}
