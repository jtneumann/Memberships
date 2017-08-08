using Memberships.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Memberships.Areas.Admin.Models
{
    public class ProductItemModel
    {
        [Display(Name = "Product Id")]
        public int ProductId { get; set; }
        [Display(Name = "Item Id")]
        public int ItemId { get; set; }
        [Display(Name = "Product")]
        public string ProductTitle { get; set; }
        [Display(Name = "Item")]
        public string ItemTitle { get; set; }

        public ICollection<Product> Products { get; set; }

        public ICollection<Item> Items { get; set; }

    }
}