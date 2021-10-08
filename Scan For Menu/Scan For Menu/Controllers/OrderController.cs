using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scan_For_Menu.Data;
using Scan_For_Menu.Helpers;
using Scan_For_Menu.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Scan_For_Menu.Controllers     //latest
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext amasole_db;
        private readonly IWebHostEnvironment _hostEnvironment;

        //links the databse to this controller
        public OrderController(ApplicationDbContext db, IWebHostEnvironment hostEnvironment)
        {
            amasole_db = db;
             _hostEnvironment = hostEnvironment;
        }


        private void writeToFile(CustomerOrder order)
        {
            try
            {
                //CustomerOrder order = SessionHelper.GetObjectFromJSON<CustomerOrder>(HttpContext.Session, "order");
                string fileName = order.OrderId.ToString();
                 string path = Path.Combine(_hostEnvironment.WebRootPath + "\\DailyOrders\\", fileName+ ".txt");

                //Add the current date to the orders along with the order number for report perposed
                string orderFile = Path.Combine(_hostEnvironment.WebRootPath + "\\DailyOrders\\Orders.txt");
                
                    using (StreamWriter sw = new StreamWriter(orderFile, true))
                    {
                        sw.WriteLine();
                        sw.WriteLine(System.DateTime.Today.ToShortDateString() + "_" + order.OrderId);
                    }

                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {

                        sw.WriteLine("OrderNum_" + order.OrderId);
                        sw.WriteLine("TableNum_" + order.TableNr);
                        sw.WriteLine(" ");
                        for (int i = 0; i < order.orderItems.Count; i++)
                        {
                            Cart item = order.orderItems[i];
                            sw.WriteLine("Item" + i + "_" + item.ItemId + "_" + item.ItemName + "_" + item.ItemPrice + "_" + item.ItemQty);
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

        // GET: CustomerOrderController

        [HttpPost]
        public IActionResult choosePayment(CustomerOrder obj)
        {
            obj.TableNr = Convert.ToInt32(HttpContext.Session.GetString("tableNum"));
            obj.orderItems = SessionHelper.GetObjectFromJSON<List<Cart>>(HttpContext.Session, "cartItems");
            obj.OrderTotal = (decimal)(Convert.ToDouble(HttpContext.Session.GetString("total")) + (double)obj.GratuityAmt);
            obj.OrderId = (int)HttpContext.Session.GetInt32("orderNum");
            obj.OrderDate = System.DateTime.Today;
            obj.OrderState = false;
            obj.OrderPaid = false;

            writeToFile(obj);
            SessionHelper.SetObjectAsJSON(HttpContext.Session, "order", obj);
            ViewBag.tableNr = obj.TableNr;
            ViewBag.totalAmt = obj.OrderTotal;
            return View();
        }


        //soumya
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult payment(IFormCollection keyValuePairs)
        {

            string payment = keyValuePairs["payment"];
            // if credit/debit chosen return payOnline
            if ( payment == "Card")
            {

                return RedirectToAction(nameof(payOnline)); // return payOnline
            }
            else
                return RedirectToAction(nameof(generateTime)); // , generate meal prep
        }

        public ActionResult payOnline()
        {
            return View();
        }


        [HttpPost]
        public ActionResult paidOnline(IFormCollection iform)
        {

            CustomerOrder order = SessionHelper.GetObjectFromJSON<CustomerOrder>(HttpContext.Session, "order");
            order.OrderPaid = true;

            return RedirectToAction(nameof(generateTime));
        }

        public ActionResult generateTime()
        {
            //do code to generate
            CustomerOrder order = SessionHelper.GetObjectFromJSON<CustomerOrder>(HttpContext.Session, "order");

            return View();
        }
    }
}
