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
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public LoginController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;

        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Staff staffObj)
        {            
            /*try
            {
                staffObj.StaffId = Convert.ToInt32(keys["staffId"].ToString());
            }
            catch
            {
                ModelState.AddModelError(nameof(Staff.StaffId), "Please enter valid staffID");
            }         
            staffObj.Password = keys["password"].ToString();*/

            if (ModelState.IsValid)
            {
                var curStaff = _dbContext.Staff.Where(a => a.StaffId.Equals(staffObj.StaffId));
                

                if (staffObj != null)
                {
                    HttpContext.Session.SetInt32("StaffId", staffObj.StaffId);
                }

                if(curStaff.Any(a => a.Password.Equals(staffObj.Password)))
                {
                    if (curStaff.Any(a => a.StaffType.Equals("Admin")))
                    {
                        return RedirectToAction("Dashboard", "Admin");
                    }

                    else if (curStaff.Any(a => a.StaffType.Equals("Kitchen")))
                    {
                        return RedirectToAction("Index", "Kitchen");
                    }

                    else if (curStaff.Any(a => a.StaffType.Equals("Waiter")))
                    {
                        return RedirectToAction("Index", "Waiter");
                    }

                }
                
               
            }
            return RedirectToAction("Login");
        }
    }
}
