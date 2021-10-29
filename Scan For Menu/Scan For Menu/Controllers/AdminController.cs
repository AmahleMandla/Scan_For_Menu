 using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scan_For_Menu.Data;
using Scan_For_Menu.Helpers;
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

        public IActionResult Report() // (me linked viewReport)
        {
            string[] filePaths = Directory.GetFiles(Path.Combine(_hostEnvironment.WebRootPath + "\\Reports"));
            List<ReportData> reportdataItems = null;
            Dictionary<string, List<ReportData>> keyValues = new Dictionary<string, List<ReportData>>();
            List<string> Dates = new List<string>();
            foreach (string file in filePaths)
            {
                ReportData data = null;
                StreamReader sr = new StreamReader(file);
                reportdataItems = new List<ReportData>();

                string[] Date = sr.ReadLine().Split('_');
                Dates.Add(Date[1]);
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    data = new ReportData();
                    string[] reportdata = sr.ReadLine().Split('_');
                    data.Category = reportdata[0];
                    data.itemName = reportdata[1];
                    data.itemQnty = int.Parse( reportdata[2]);
                    data.LineTotal = double.Parse(reportdata[3]);
                   
                    reportdataItems.Add(data);
                }
                keyValues.Add(Date[1], reportdataItems);
            }

            SessionHelper.SetObjectAsJSON(HttpContext.Session, "Reports", keyValues);
            
            return View(Dates);
        }

        public IActionResult ViewReport(string date)
        {
            if(date == null)
            {
                return NotFound();
            }
            ViewBag.Date = date;
            Dictionary<string, List<ReportData>> keyValues = SessionHelper.GetObjectFromJSON<Dictionary<string, List<ReportData>>>(HttpContext.Session, "Reports");
            List<ReportData> todayReport = keyValues[date];

            List<ReportData> drinkData = new List<ReportData>();
            List<ReportData> burgerData = new List<ReportData>();
            List<ReportData> saladData = new List<ReportData>();
            List<ReportData> desertData = new List<ReportData>();
            List<ReportData> steakData = new List<ReportData>();

            ViewBag.TotalRevenue = 0;
            ViewBag.TotItems = 0;

            foreach(var data in todayReport)
            {
                ViewBag.TotalRevenue += data.LineTotal;
                ViewBag.TotItems += data.itemQnty;

                if (data.Category == "Drinks")
                {
                    drinkData.Add(data);
                }
                else if(data.Category == "Burgers")
                {
                    burgerData.Add(data);
                }
                else if(data.Category == "Soup, Salad and Sides")
                {
                    saladData.Add(data);
                }
                else if(data.Category== "Steaks and Grills")
                {
                    steakData.Add(data);
                }
                else
                {
                    desertData.Add(data);
                }
            }

            ViewBag.drinks = drinkData;
            ViewBag.burgers = burgerData;
            ViewBag.deserts = desertData;
            ViewBag.salads = saladData;
            ViewBag.steaks = steakData;

            return View();
        }

        public IActionResult ViewItems()
        {
            ViewBag.filter = "No Filter";
            ViewBag.foodCategories = categoryObj;
            return View(menuItemObj);
        }


        [HttpPost]
        public IActionResult ViewItems(IFormCollection keyValuePairs)
        {

            string filter = keyValuePairs["category"];
            if ((filter == "All")|| (filter == "No filter"))
            {
                return RedirectToAction("ViewItems", menuItemObj);
            }
            FoodCategory category = _dbContext.FoodCategory.Where(obj => obj.CategoryName == filter).Single();
            IEnumerable<MenuItem> filteredItemObj = _dbContext.MenuItem.Where(obj => obj.CategoryId == category.CategoryId);
            ViewBag.foodCategories = categoryObj;
            ViewBag.filter = filter;
            return View("ViewItems", filteredItemObj);
        }

        public IActionResult Dashboard()
        {

            return View();
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View();
            }
        }

        //get for editing
        public IActionResult Edit(int? Id)
        {
            if((Id == null) || (Id == 0)){
                return NotFound();
            }

            var obj = menuItemObj.Single(obj => obj.ItemId == Id);
       
            try
            {
                string path = Path.Combine(_hostEnvironment.WebRootPath + "\\MenuItem\\", obj.ItemImage);
                using (var fileStream = new FileStream(path, FileMode.Open))
                {
                    //Add file to path
                    obj.Image = new FormFile(fileStream, 0, fileStream.Length, null, Path.GetFileName(fileStream.Name));
                }
            }catch(Exception e)
            {
                return NotFound();
            }

            obj.CategoryName = _dbContext.FoodCategory.Find(obj.CategoryId).CategoryName;
            if(obj == null)
            { return NotFound(); }

            return View(obj);
        }

        //POST - Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(MenuItem obj)
        {
            if (ModelState.IsValid) { 

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
            }
            else
            {
                if (obj.Image == null)
                {
                    obj.ItemImage = obj.ItemImage;//assign image name
                                                                                //no need for a new path because the image already exists in file
                }
                else
                {
                    return View(obj);
                }
                
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
            

                _dbContext.Update(obj);
                _dbContext.SaveChanges();
                return RedirectToAction("ViewItems");
   
        }


        public IActionResult Delete(int? Id)
        {
            if((Id == null) || (Id== 0)){
                return NotFound();
            }
            var obj = _dbContext.MenuItem.Find(Id);
             if(obj == null)
            {
                return NotFound();
            }

            obj.CategoryName = _dbContext.FoodCategory.Find(obj.CategoryId).CategoryName;


            return View(obj);
        }

        [HttpPost]
        public IActionResult DeletePost(int? Id)
        {
            if ((Id == null) || (Id == 0))
            {
                return NotFound();
            }
            var obj = _dbContext.MenuItem.Find(Id);
            _dbContext.MenuItem.Remove(obj);
            _dbContext.SaveChanges();
            return RedirectToAction("ViewItems");
        }

        public IActionResult endOfDay()
        {
            string curDate = System.DateTime.Today.ToShortDateString();

            string orderPath = Path.Combine(_hostEnvironment.WebRootPath + "\\DailyOrders\\Orders.txt");
            Dictionary<string, List<string>> Orders = new Dictionary<string, List<string>>();
            List<string> Dates = new List<string>();
            StreamReader sr = new StreamReader(orderPath);
            sr.ReadLine();
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string[] dailyOrders = sr.ReadLine().Split("_");
                string orderDate = dailyOrders[0];
                string orderNum = dailyOrders[1];
                if (!Orders.ContainsKey(orderDate))
                {
                    Orders.Add(orderDate, new List<string>());
                    Dates.Add(orderDate);
                }

                Orders.GetValueOrDefault(orderDate).Add(orderNum);
            }
            sr.Close();


            List<int> itemIds = null;
            foreach (var date in Dates)
            {
                Dictionary<int, ReportData> reportData = new Dictionary<int, ReportData>();
                List<String> orderNums = Orders.GetValueOrDefault(date);
                itemIds = new List<int>();

                foreach (var orderNum in orderNums)
                {
                    IEnumerable<OrderLine> lines = _dbContext.OrderLine.Where(order => order.OrderId == Convert.ToInt32(orderNum));
                    
                    foreach (OrderLine line in lines)
                    {
                        MenuItem item = _dbContext.MenuItem.Find(line.ItemId);
                         string catName = _dbContext.FoodCategory.Find(item.CategoryId).CategoryName;
                        if (!reportData.ContainsKey(item.ItemId))
                        {

                            itemIds.Add(item.ItemId);
                            ReportData data = new ReportData();
                            data.itemName = item.ItemName;
                            data.itemQnty = line.Quantity;
                            data.Category = catName;
                            data.LineTotal = (double)line.OrderLineTotal;
                            reportData.Add(item.ItemId, data);
                        }
                        else
                        {
                            ReportData data = reportData.GetValueOrDefault(item.ItemId);
                            data.itemQnty += line.Quantity;
                            data.Category = catName;
                            data.LineTotal += (double)line.OrderLineTotal;
                            reportData[item.ItemId] = data;
                        }
                    }
                }

                //write t ofile
                writeToFile(date, itemIds, reportData);
            }                                  
            return View("Dashboard");
        }

        private void writeToFile(String date, List<int> items, Dictionary<int,ReportData> reports)
        {
            try
            {                
                string[] fileNames = date.Split('/');
                string fileName = fileNames[0] + fileNames[1] + fileNames[2];
                string path = Path.Combine(_hostEnvironment.WebRootPath + "\\Reports\\" + fileName + ".txt");

                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {

                        sw.WriteLine("Date_" + date);
                        sw.WriteLine(" ");
                        foreach (var id in items) {

                            ReportData data = reports.GetValueOrDefault(id);
                            sw.WriteLine(data.Category +"_"+ data.itemName+ "_"+ data.itemQnty+"_"+data.LineTotal);
                        }
                        sw.Close();
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
