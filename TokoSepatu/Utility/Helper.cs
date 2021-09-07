using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TokoSepatu.Utility
{
    public class Helper
    {
        public static string Owner = "Owner";
        public static string Admin = "Admin";

        public static List<SelectListItem> GetRolesFromDropDown()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{Value=Helper.Owner,Text=Helper.Owner},
                new SelectListItem{Value=Helper.Admin,Text=Helper.Admin},
            };
        }
    }
}
