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
using Scan_For_Menu.Helpers;

namespace Scan_For_Menu.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        List<Cart> cartItems = new List<Cart>();

        public CartController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        // GET: CartController
        public IActionResult ViewCart()
        {
            cartItems = SessionHelper.GetObjectFromJSON<List<Cart>>(HttpContext.Session, "cartItems");
            return View(cartItems);
        }



        [HttpPost]
        public void shoppingCart(int ItemId, int Quantity)
        {

            Cart cartItemObj = new Cart();
            MenuItem menuItemObj = _dbContext.MenuItem.Single(model => model.ItemId == ItemId);

            if (HttpContext.Session.GetInt32("CartCounter") != null)
            {
                cartItems = SessionHelper.GetObjectFromJSON<List<Cart>>(HttpContext.Session, "cartItems");
            }
            if (cartItems.Any(model => model.ItemId == ItemId))
            {
                cartItemObj = cartItems.Single(model => model.ItemId == ItemId);
                cartItemObj.ItemQty += Quantity;
                cartItemObj.ItemPrice = menuItemObj.ItemPrice;
                cartItemObj.Category = menuItemObj.CategoryName;
            }
            else
            {
                cartItemObj.ItemId = ItemId;
                cartItemObj.ItemName = menuItemObj.ItemName;
                cartItemObj.ItemQty = Quantity;
                cartItemObj.ItemPrice = menuItemObj.ItemPrice;
                cartItemObj.Category = menuItemObj.CategoryName;
                cartItems.Add(cartItemObj);
            }            
            HttpContext.Session.SetInt32("CartCounter", cartItems.Count);
            SessionHelper.SetObjectAsJSON(HttpContext.Session, "cartItems", cartItems);
        }

        public IActionResult updateCart(int ItemId, int Quantity)
        {
            Cart cartItemObj = new Cart();
            cartItems = SessionHelper.GetObjectFromJSON<List<Cart>>(HttpContext.Session, "cartItems");
            cartItemObj = cartItems.Single(model => model.ItemId == ItemId);

            if (Quantity > cartItemObj.ItemQty)
            {
                cartItemObj.ItemQty += (Quantity - cartItemObj.ItemQty);
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

            if (cartItemObj.ItemQty == 0)
            {
                cartItems.Remove(cartItemObj);
            }
            else if (cartItemObj.ItemQty > 20)
            {
                cartItemObj.ItemQty = 20;
            }

            HttpContext.Session.SetInt32("GratuityAmt", 0);
            HttpContext.Session.SetInt32("CartCounter", cartItems.Count);
            SessionHelper.SetObjectAsJSON(HttpContext.Session, "cartItems", cartItems);


            return RedirectToAction("ViewCart");
        }

        [Route("/Cart/removeItem/{ItemId}")]
        public IActionResult removeItem(int ItemId)
        {
            Cart cartItemObj = new Cart();
            cartItems = SessionHelper.GetObjectFromJSON<List<Cart>>(HttpContext.Session, "cartItems");
            cartItemObj = cartItems.Single(model => model.ItemId == ItemId);

            cartItems.Remove(cartItemObj);

            HttpContext.Session.SetInt32("CartCounter", cartItems.Count);
            SessionHelper.SetObjectAsJSON(HttpContext.Session, "cartItems", cartItems);
            return RedirectToAction("ViewCart");

        }

        public IActionResult clearCart()
        {
            cartItems.Clear();

            HttpContext.Session.SetInt32("CartCounter", cartItems.Count);
            SessionHelper.SetObjectAsJSON(HttpContext.Session, "cartItems", cartItems);

            return RedirectToAction("ViewCart");
        }

    }
}
