using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scan_For_Menu.Controllers
{
    public class WaiterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
