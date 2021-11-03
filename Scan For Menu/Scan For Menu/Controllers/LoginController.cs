using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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

            if (ModelState.IsValid)
            {
                //  var curStaff = _dbContext.Staff.Where(a => a.StaffId.Equals(staffObj.StaffId));
                var curStaff = _dbContext.Staff.Find(staffObj.StaffId);


                if (curStaff != null)
                {
                    HttpContext.Session.SetInt32("StaffId", curStaff.StaffId);

                    if (curStaff.Password == staffObj.Password)
                    {
                        if (curStaff.StaffType.Equals("Admin"))
                        {
                            return RedirectToAction("Dashboard", "Admin");
                        }
                        else if (curStaff.StaffType.Equals("Kitchen"))
                        {
                            return RedirectToAction("Index", "Kitchen");
                        }
                        else if (curStaff.StaffType.Equals("Waiter"))
                        {
                            return RedirectToAction("Index", "Waiter");
                        }
                        else
                        {
                            ModelState.AddModelError("", "User name and password is invalid");

                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "User name and password is invalid");
                    }
                }
            }
            ModelState.AddModelError("", "User name and password is invalid");
            return View();
            
        }
    }
}
