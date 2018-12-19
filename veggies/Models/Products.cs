using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System;
using System.Collections.Generic;

namespace veggies.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }

        [Display(Name = "Name")]
        public string ProductName { get; set; }
        [Display(Name = "Price")]
        public float ProductPrice { get; set; }
        [Display(Name = "Image")]
        public byte[] ProductImage { get; set; }

        //[Display(Name = "Percent")]
        //public double ProductDropPercent { get; set; }
        //[Display(Name = "Description")]
        //public string ProductDesc { get; set; }
        //[Display(Name = "SpecialEndDate")]
        //public DateTime ProductDateEndPromo { get; set; }
        //[Display(Name = "Catagory")]
        ////public IEnumerable<ProductCatagory> productCatagories { get; set; }

        //public ProductCatagory Catagory { get; set; }

        //public ICollection<PnpSales> Sales { get; set; }

        //public List<ProductCatagory> productCatagoy { get; set; }




    }
}