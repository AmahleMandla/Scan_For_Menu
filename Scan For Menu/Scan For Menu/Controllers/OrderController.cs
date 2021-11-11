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
            obj.OrderDate = DateTime.Parse(System.DateTime.Today.ToShortDateString());
            obj.OrderState = false;
            obj.OrderPaid = false;

            writeToFile(obj);
            SessionHelper.SetObjectAsJSON(HttpContext.Session, "order", obj);
            ViewBag.tableNr = obj.TableNr;
            ViewBag.totalAmt = obj.OrderTotal;
            HttpContext.Session.SetString("TotalAmt", Math.Ceiling(obj.OrderTotal).ToString());
            return View();
        }


        public ActionResult payment()
        {

            CustomerOrder order = SessionHelper.GetObjectFromJSON<CustomerOrder>(HttpContext.Session, "order");
            string fileName = order.TableNr.ToString();
            string path = Path.Combine(_hostEnvironment.WebRootPath + "\\Receipts\\", fileName + ".txt");

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {

                        sw.WriteLine("OrderNum_" + order.OrderId);
                        sw.WriteLine("Date_" + System.DateTime.Today.ToShortDateString());
                        sw.WriteLine(" ");
                        sw.WriteLine("SubTotal" + "_" + (HttpContext.Session.GetString("total")));
                        sw.WriteLine("Gratuity" + "_" + order.GratuityAmt);
                        sw.WriteLine("Total" + "_" + order.OrderTotal);
                        for (int i = 0; i < order.orderItems.Count; i++)
                        {
                            Cart item = order.orderItems[i];
                            sw.WriteLine("Item" + i + "_" + item.ItemName + "_" + item.ItemQty + "_" + item.ItemPrice);
                        }
                        sw.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

                return RedirectToAction(nameof(generateTime)); // , generate meal prep                          
        }

        public ActionResult payOnline()
        {
            ViewBag.tot = HttpContext.Session.GetString("TotalAmt");
            return View();
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult paidOnline(PayOnline obj)
        {
            if (ModelState.IsValid)
            {
                CustomerOrder order = SessionHelper.GetObjectFromJSON<CustomerOrder>(HttpContext.Session, "order");
                order.OrderPaid = true;
                //write to textfile

             //   CustomerOrder order = SessionHelper.GetObjectFromJSON<CustomerOrder>(HttpContext.Session, "order");
/*                string fileName = order.TableNr.ToString();
                string path = Path.Combine(_hostEnvironment.WebRootPath + "\\Receipts\\", fileName + ".txt");

                try
                {
                    using (FileStream fs = new FileStream(path, FileMode.Create))
                    {
                        using (StreamWriter sw = new StreamWriter(fs))
                        {

                            sw.WriteLine("OrderNum_" + order.OrderId);
                            sw.WriteLine("Date_" + System.DateTime.Today.ToShortDateString());
                            sw.WriteLine(" ");
                            sw.WriteLine("SubTotal" + "_" + (HttpContext.Session.GetString("total")));
                            sw.WriteLine("Gratuity" + "_" + order.GratuityAmt);
                            sw.WriteLine("Total" + "_" + order.OrderTotal);
                            for (int i = 0; i < order.orderItems.Count; i++)
                            {
                                Cart item = order.orderItems[i];
                                sw.WriteLine("Item" + i + "_" + item.ItemName + "_" + item.ItemQty + "_" + item.ItemPrice);
                            }
                            sw.Close();
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }*/

                HttpContext.Session.SetObjectAsJSON("order", order);
                //changed the above lines of code

                return RedirectToAction(nameof(generateTime));
            }
            ViewBag.tot = HttpContext.Session.GetString("TotalAmt");
            return View("payOnline");
           
        }

        public ActionResult generateTime()
        {
            //do code to generate meal prep time estimate
            CustomerOrder order = SessionHelper.GetObjectFromJSON<CustomerOrder>(HttpContext.Session, "order");
            
                  int orderTime = 0;

            foreach (Cart item in order.orderItems)
            {
                MenuItem item1 = amasole_db.MenuItem.Find(item.ItemId);

                if (item1.MealPrepTime >= orderTime)
                {
                    // make that the time estimate
                    orderTime = item1.MealPrepTime;
                }

            }


            ViewBag.Time = orderTime;
            AddToDb();
            return View();
        }

        public  void AddToDb()
        {
            CustomerOrder order = SessionHelper.GetObjectFromJSON<CustomerOrder>(HttpContext.Session, "order");
            OrderLine orderItem;
            List <OrderLine> orderLineItems= new List<OrderLine>();
            
            
            ///    for (int i = 0; i < order.orderItems.Count; i++)
            foreach (var cart in order.orderItems)
            {
                orderItem = new OrderLine();
                orderItem.OrderId = order.OrderId;
                orderItem.ItemId = cart.ItemId;
                orderItem.Quantity = cart.ItemQty;
                orderItem.OrderLineTotal = (decimal)(cart.ItemPrice * cart.ItemQty);
                amasole_db.OrderLine.Add(orderItem);
                amasole_db.SaveChanges();

                //amasole_db.OrderLine.Add(orderItem);
            }
          
            amasole_db.CustomerOrder.Add(order);
            amasole_db.SaveChanges();

        }
    }
}
