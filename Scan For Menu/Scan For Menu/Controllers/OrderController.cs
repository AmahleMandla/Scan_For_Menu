using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scan_For_Menu.Data;
using Scan_For_Menu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scan_For_Menu.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext amasole_db;
        private int tableNr { get; set; } //for the table number
        private int orderId { get; set; } //order number
        private float gratuity { get; set; } //tip
        private float orderTotal { get; set; } //total paid
        private Dictionary<MenuItem, int> orderItems { get; set; } //store the items in an order along with qnty

        //links the databse to this controller
        public OrderController(ApplicationDbContext db)
        {
            amasole_db = db;
        }

        

        // GET: CustomerOrderController
        public IActionResult Menu()
        {
            return View();
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
