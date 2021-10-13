using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Scan_For_Menu.Helpers;
using Scan_For_Menu.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Scan_For_Menu.Controllers
{
    public class WaiterController : Controller
    {
        private readonly IWebHostEnvironment _hostEnvironment;


        public WaiterController(IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {

            string[] filePaths = Directory.GetFiles(Path.Combine(_hostEnvironment.WebRootPath + "\\Receipts"));
            List<ReportData> reportdataItems = null;
            Dictionary<string, List<ReportData>> keyValues = new Dictionary<string, List<ReportData>>();
            List<string> tableNum = new List<string>();
            foreach (string file in filePaths)
            {
                FileInfo file1 = new FileInfo(file);
                string tblNum = file1.Name.Substring(0,1);
                tableNum.Add(tblNum);
                ReportData data = null;
                StreamReader sr = new StreamReader(file);
                reportdataItems = new List<ReportData>();

                string[] orderNum = sr.ReadLine().Split('_');
                string[] Date = sr.ReadLine().Split('_');
                sr.ReadLine();
                string[] subtotal = sr.ReadLine().Split('_');
                string[] gratuity = sr.ReadLine().Split('_');
                string[] total =  sr.ReadLine().Split('_');
             


                while (!sr.EndOfStream)
                {
                    data = new ReportData();
                    string[] reportdata = sr.ReadLine().Split('_');
                    data.gratuity = double.Parse(gratuity[1]);
                    data.subtotal = double.Parse(subtotal[1]);
                    data.Total = double.Parse(total[1]);
                    data.orderNum = int.Parse(orderNum[1]);
                    data.itemName = reportdata[1];
                    data.itemQnty = int.Parse(reportdata[2]);
                    data.LineTotal = double.Parse(reportdata[3]);

                    reportdataItems.Add(data);
                }
                keyValues.Add(tblNum, reportdataItems);
            }

            SessionHelper.SetObjectAsJSON(HttpContext.Session, "Receipts", keyValues);

            return View(tableNum);
        }

        public IActionResult Receipt(int? tblNum)
        {
            if ((tblNum == null) || (tblNum == 0))
            {
                return NotFound();
            }

            ViewBag.TblNum = tblNum;
            Dictionary<string, List<ReportData>> keyValues = SessionHelper.GetObjectFromJSON<Dictionary<string, List<ReportData>>>(HttpContext.Session, "Receipts");
            List<ReportData> tblReceipt = keyValues[tblNum.ToString()];
            ViewBag.Date = tblReceipt[0].Date;
            ViewBag.Total = tblReceipt[0].Total;
            ViewBag.OrderNum = tblReceipt[0].orderNum;
            ViewBag.subtot = tblReceipt[0].subtotal;
            ViewBag.gratuity = tblReceipt[0].Total;

            return View(tblReceipt);
        }

        public IActionResult PrintBill(int? tableNr)
        {
            if ((tableNr == null) || (tableNr == 0))
            {
                return NotFound();
            }

            String path = Path.Combine(_hostEnvironment.WebRootPath + "\\Receipts\\" + tableNr + ".txt");

            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {
                file.Delete();
            }
            return RedirectToAction("Index");
        }
    }
}
