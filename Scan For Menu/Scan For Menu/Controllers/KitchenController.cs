using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Scan_For_Menu.Data;
using Scan_For_Menu.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Scan_For_Menu.Controllers
{
    public class KitchenController : Controller
    {

        private readonly ApplicationDbContext amasole_db;
        private readonly IWebHostEnvironment _hostEnvironment;
        KitchenOrder kitchen;

        //links the databse to this controller
        public KitchenController(ApplicationDbContext db, IWebHostEnvironment hostEnvironment)
        {
            amasole_db = db;
            _hostEnvironment = hostEnvironment;
             
        }

        public IActionResult Index()
        {
            List<KitchenOrder> orders = new List<KitchenOrder>();
            string[] filePaths = Directory.GetFiles(Path.Combine(_hostEnvironment.WebRootPath+ "\\DailyOrders"));
            string orderPath =  Path.Combine(_hostEnvironment.WebRootPath + "\\DailyOrders\\Orders.txt");
            foreach (string file in filePaths)
            {
                if (!file.Equals(orderPath))
                {
                    StreamReader sr = new StreamReader(file);
                    string[] orderNum = sr.ReadLine().Split('_');
                    string[] tableNum = sr.ReadLine().Split('_');
                    sr.ReadLine();
                    Cart cartItem = new Cart();

                    kitchen = new KitchenOrder();
                    kitchen.orders = new List<Cart>();
                    kitchen.OrderNum = int.Parse(orderNum[1]);
                    kitchen.tableNum = int.Parse(tableNum[1]);

                    while (!sr.EndOfStream)
                    {
                        string[] item = sr.ReadLine().Split('_');
                        cartItem.ItemId = int.Parse(item[1]);
                        cartItem.ItemName = item[2];
                        cartItem.ItemPrice = float.Parse(item[3]);
                        cartItem.ItemQty = int.Parse(item[4]);
                        kitchen.orders.Add(cartItem);
                        cartItem = new Cart();
                    }
                    sr.Close();
                    orders.Add(kitchen);
                }
            }

            return View(orders);
        }

        [HttpPost]
        public ActionResult remove(KitchenOrder orderToRemove, List<KitchenOrder> orders)
        {

            return View("Index", orders);
        }
    }
}
