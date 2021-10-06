using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scan_For_Menu.Data;
using Scan_For_Menu.Helpers;
using Scan_For_Menu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scan_For_Menu.Controllers     //latest
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext amasole_db;


        //links the databse to this controller
        public OrderController(ApplicationDbContext db)
        {
            amasole_db = db;
        }


        // GET: CustomerOrderController

        [HttpPost]
        public IActionResult choosePayment(CustomerOrder obj)
        {
            obj.TableNr = Convert.ToInt32(HttpContext.Session.GetString("tableNum"));
            obj.orderItems = SessionHelper.GetObjectFromJSON<List<Cart>>(HttpContext.Session, "cartItems");
            obj.OrderTotal = (decimal)(Convert.ToDouble(HttpContext.Session.GetString("total")) + (double)obj.GratuityAmt);
            obj.OrderDate = System.DateTime.Today;
            obj.OrderState = false;
            obj.OrderPaid = false;

            SessionHelper.SetObjectAsJSON(HttpContext.Session, "order", obj);
            ViewBag.tableNr = obj.TableNr;
            ViewBag.totalAmt = obj.OrderTotal;
            return View();
        }


        //soumya
        [Route("/Order/choosePayment/{total}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult payment(ChoosePayment obj)
        {


            // if credit/debit chosen return payOnline
            if (obj.paymentType == "Card")
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
        public ActionResult paidOnline()
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
