using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OfficialSite.Models
{

    [Serializable()]
    public class Products
    {
        public List<SoftwareProduct> SoftwareProducts { get; set; }
        public List<HardwareProduct> HardwareProducts { get; set; }
        public List<OtherProduct> OtherProducts { get; set; } 
    }

    [Serializable()]
    public class SoftwareProduct
    {
       
        public string Number;
       
        public string Title;
        public string SubTitle;
        public string ShortDescription;
        public string LongDescription;
        public string ImageLink;
        public string HtmlIcon;
        public string Price;
        public string Duration;
        public int Rating;


    }

    [Serializable()]
    public class HardwareProduct
    {
        
        public string Number;       
        public string Title;       
        public string ShortDescription;
        public string LongDescription;
        public string ImageLink;
        public string HtmlIcon;
        public string Price;
        public string Duration;
        public int Rating;

    }

    [Serializable()]
    public class OtherProduct
    {

        public string Number;
        public string Title;
        public string ShortDescription;
        public string LongDescription;
        public string ImageLink;
        public string HtmlIcon;
        public string Price;
        public string Duration;
        public int Rating;

    }

    
}