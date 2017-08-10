using Memberships.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Memberships.Areas.Admin.Models
{
    public class SubscriptionProductModel
    {
        [Display(Name = "Product Id")]
        public int ProductId { get; set; }

        [Display(Name = "Subscription Id")]
        public int SubscriptionId { get; set; }

        [Display(Name = "Product")]
        public string ProductTitle { get; set; }

        [Display(Name = "Subscription Title")]
        public string SubscriptionTitle { get; set; }

        public ICollection<Product> Products { get; set; }

        public ICollection<Subscription> Subscriptions { get; set; }

    }
}