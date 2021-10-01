using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scan_For_Menu.Data;
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
        public IActionResult choosePayment(CustomerOrder total)
        {
            ViewBag.totalAmt = total;
            return View();
        }


        //soumya
        [Route("/Order/choosePayment/{total}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult something(ChoosePayment obj)
        {
            // if credit/debit chosen return payOnline
            if (obj.paymentType == "Card")
                return View(); // return payOnline
            else
                return View(); // , generate meal prep

        }


        // GET: CustomerOrderController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerOrderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerOrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerOrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerOrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerOrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerOrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
