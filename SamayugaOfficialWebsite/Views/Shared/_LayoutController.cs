using OfficialSite.Properties;
using Samayuga.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OfficialSite.Contoller
{
    public class _LayoutController : Controller
    {
       
        // GET: Layout
        public ActionResult Index()
        {
            return View();
        }

        public FileStreamResult GetLogo(string key)
        {

            var bitmap = (Bitmap)Resources.Logo;
            MemoryStream stream = new MemoryStream();
            bitmap.Save(stream, ImageFormat.Png);
            stream.Seek(0, SeekOrigin.Begin);
            return new FileStreamResult(stream, "image/png");

        }

       
    }
}