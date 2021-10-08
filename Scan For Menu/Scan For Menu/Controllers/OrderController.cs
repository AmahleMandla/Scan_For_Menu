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


        private void writeToFile(string fileName)
        {
            string path = Path.Combine(_hostEnvironment.WebRootPath + "\\DailyOrders\\", fileName+".txt");
            try
            {
              

            }catch(Exception ex)
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
