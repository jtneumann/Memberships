using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Memberships.Extensions
{
    public static class ICollectionExtensions
    {
        public static IEnumerable<SelectListItem> ToSelectListItem<T>(this ICollection<T>items, int selectedValue)
        {
            return from item in items
                   select new SelectListItem
                   {
                       // Cannot get props directly bc item is of type T
                       // Solving with reflection; calling GetPropertyValue method
                       // to return a string containing the property value
                       Text = item.GetPropertyValue("Title"),
                       Value = item.GetPropertyValue("Id"),
                       Selected = item.GetPropertyValue("Id")
                       .Equals(selectedValue.ToString())
                   };
        }
    }
}