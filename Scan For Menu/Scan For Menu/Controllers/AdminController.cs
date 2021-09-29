using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scan_For_Menu.Data;
using Scan_For_Menu.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Scan_For_Menu.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IWebHostEnvironment _hostEnvironment;
        dynamic mymodel = new ExpandoObject();
        private IEnumerable<FoodCategory> categoryObj;
        private IEnumerable<MenuItem> menuItemObj;

        public AdminController(ApplicationDbContext dbContext, IWebHostEnvironment hostEnvironment)
        {
            _dbContext = dbContext;
            _hostEnvironment = hostEnvironment;

             menuItemObj = _dbContext.MenuItem;
             categoryObj = _dbContext.FoodCategory;
            mymodel.MenuItem = menuItemObj;
            mymodel.FoodCategory = categoryObj;
        }

       
        public IActionResult ViewItems()
        {
           
            return View(mymodel);
        }

        [HttpPost]
        public IActionResult filteredItems(IFormCollection keyValuePairs)
        {
            string filter = keyValuePairs["category"];
            if (filter == "All")
            {
                return RedirectToAction("ViewItems");
            }
                FoodCategory category = _dbContext.FoodCategory.Where(obj => obj.CategoryName == filter).Single();
                menuItemObj = _dbContext.MenuItem.Where(obj => obj.CategoryId == category.CategoryId);
                mymodel.MenuItem = menuItemObj;
                mymodel.FoodCategory = categoryObj;
                return View(mymodel);
        }

        //GET - CREATE
        public IActionResult Create() {

            return View();
        }

        //POST - CREATE
         [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MenuItem obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string wwwrootPath = _hostEnvironment.WebRootPath;
                    
                    string fileName = Path.GetFileNameWithoutExtension(obj.Image.FileName);
                    string extension = Path.GetExtension(obj.Image.FileName);
                    string imageName = fileName + extension;
                    obj.ItemImage = imageName; //assign image name
                    string path = Path.Combine(wwwrootPath + "\\MenuItem\\", imageName);

                    using (var fileStream = new FileStream(path, FileMode.OpenOrCreate))
                    {
                        //Add file to path
                        obj.Image.CopyTo(fileStream);
                    }

                    foreach (FoodCategory category in categoryObj)
                    {
                        if (category.CategoryName == obj.CategoryName)
                        {
                            //link the catecory ID
                            obj.CategoryId = category.CategoryId;
                            break; // exit foreach loop
                        }
                    }

                    _dbContext.Add(obj);
                    _dbContext.SaveChanges();
                    return RedirectToAction("ViewItems");
                }
                return View(obj);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return View();
            }
        }
    }
}
