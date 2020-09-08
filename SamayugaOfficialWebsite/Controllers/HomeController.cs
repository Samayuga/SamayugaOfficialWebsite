using OfficialSite.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OfficialSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            
            return View();
        }

        public ActionResult SiteMap()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Feedback()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult RandD()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
        

        public ActionResult Solution()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
       

       
    }
}