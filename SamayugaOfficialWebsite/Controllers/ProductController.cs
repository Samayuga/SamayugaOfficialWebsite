using OfficialSite.Models;
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
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {

            System.Xml.Serialization.XmlSerializer SoftwareXmlSerializer =
                new System.Xml.Serialization.XmlSerializer(typeof(List<SoftwareProduct>));
            System.IO.StreamReader SoftwareStreamReader = new System.IO.StreamReader(Server.MapPath("/App_Data/SoftwareProducts.xml"));
            List<SoftwareProduct> SoftwareProducts = (List<SoftwareProduct>)SoftwareXmlSerializer.Deserialize(SoftwareStreamReader);
            SoftwareStreamReader.Close();

            System.Xml.Serialization.XmlSerializer HardwareXmlSerializer =
                new System.Xml.Serialization.XmlSerializer(typeof(List<HardwareProduct>));
            System.IO.StreamReader HardwareStreamReader = new System.IO.StreamReader(Server.MapPath("/App_Data/HardwareProducts.xml"));
            List<HardwareProduct> HardwareProducts = (List<HardwareProduct>)HardwareXmlSerializer.Deserialize(HardwareStreamReader);
            HardwareStreamReader.Close();

              System.Xml.Serialization.XmlSerializer OtherXmlSerializer =
                new System.Xml.Serialization.XmlSerializer(typeof(List<OtherProduct>));
            System.IO.StreamReader OtherStreamReader = new System.IO.StreamReader(Server.MapPath("/App_Data/OtherProducts.xml"));
            List<OtherProduct> OtherProducts = (List<OtherProduct>)OtherXmlSerializer.Deserialize(OtherStreamReader);
            OtherStreamReader.Close();                       
            
            //var CombinedProductTouple = new Tuple<List<SoftwareProduct>,List<HardwareProduct>>(SoftwareProducts, HardwareProducts);
            Products Products = new Products();
            Products.SoftwareProducts = SoftwareProducts;
            Products.HardwareProducts = HardwareProducts;
            Products.OtherProducts = OtherProducts;
            return View(Products);
        }
    }
}