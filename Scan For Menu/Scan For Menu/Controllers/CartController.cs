using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Scan_For_Menu.Data;
using Scan_For_Menu.Models;
using System.Web;
using Newtonsoft.Json;

namespace Scan_For_Menu.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        List<Cart> cartItems;
        Cart cartItem;

        public CartController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            // cartItem = new Cart();

        }
        // GET: CartController
        public IActionResult ViewCart()
        {
            //cartItems = ViewBag.CartItem as List<Cart>;
            IEnumerable<Cart> CartItems = _dbContext.Cart;
            calcTotal(CartItems);

            return View(CartItems);
        }

        private void calcTotal(IEnumerable<Cart> CartItems)
        {
            float subtotal = 0;
            int qnty = 0;
            float price = 0;

            foreach (Cart cart in CartItems)
            {
                qnty = cart.ItemQty;
                price = cart.ItemPrice;
                subtotal += (qnty * price);
            }

            ViewBag.Subtotal = subtotal;
            ViewBag.Gratuity = 0;
        }
        [HttpPost]
        public void shoppingCart(int ItemId, int Quantity)
        {
            // cartItems = new List<Cart>();
            // objCart.ItemId = ItemId;
            IEnumerable<MenuItem> objItem = _dbContext.MenuItem.Where(curItem => curItem.ItemId == ItemId);
                
            IEnumerable<Cart> cartItem = _dbContext.Cart.Where(model => model.ItemId == ItemId);

            Cart cartItemObj = null;

            //
            if (cartItem.Count() > 0)
            {
                cartItemObj = cartItem.Single(model => model.ItemId == ItemId);
            }

            MenuItem menuItemObj = new MenuItem();
            try
            {
                
               menuItemObj = objItem.Single(model => model.ItemId == ItemId);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (cartItemObj!=null)
            {
                if(menuItemObj != null)
                {
                    cartItemObj.ItemQty += Quantity;
                    _dbContext.Update(cartItemObj);
                    _dbContext.SaveChanges();
                }               
            }
            else
            {
                cartItemObj = new Cart();
                cartItemObj.ItemId = ItemId;
                cartItemObj.ItemName = menuItemObj.ItemName;
                cartItemObj.ItemQty = Quantity;
                cartItemObj.ItemPrice = (menuItemObj.ItemPrice);
                _dbContext.Add(cartItemObj);
                _dbContext.SaveChanges();
            }
          }

        [HttpPost]
        public IActionResult updateCart(int ItemId, int Quantity)
        {
            IEnumerable<Cart> cartItem = _dbContext.Cart.Where(model => model.ItemId == ItemId);
            Cart cartItemObj = cartItem.Single(model => model.ItemId == ItemId);

            if (Quantity > cartItemObj.ItemQty)
            {
                cartItemObj.ItemQty += (Quantity- cartItemObj.ItemQty);
            }
            else
            {
                if (Quantity == cartItemObj.ItemQty)
                {
                    cartItemObj.ItemQty = cartItemObj.ItemQty;
                }
                else
                {
                    cartItemObj.ItemQty -= (cartItemObj.ItemQty - Quantity);
                }

            }

            if(cartItemObj.ItemQty == 0)
            {
                _dbContext.Remove(cartItemObj);
            }else if (cartItemObj.ItemQty > 20)
            {
                cartItemObj.ItemQty = 20;
                _dbContext.Update(cartItemObj);
            }
            else
            {
                _dbContext.Update(cartItemObj);
            }

            _dbContext.SaveChanges();
            calcTotal(cartItem);
            return View("ViewCart");
        }

        public IActionResult clearCart()
        {
            IEnumerable<Cart> cartObj = _dbContext.Cart;

            foreach (var curObj in _dbContext.Cart)
            {
                _dbContext.Remove(curObj);
            }
            _dbContext.SaveChanges();

            return View("ViewCart");
        }
        // GET: CartController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: CartController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CartController/Create
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

        // GET: CartController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CartController/Edit/5
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

        // GET: CartController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CartController/Delete/5
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
