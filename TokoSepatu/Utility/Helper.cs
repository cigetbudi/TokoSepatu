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
        public static string dataAdded = "Data telah ditambahkan.";
        public static string dataUpdated = "Data telah dirubah.";
        public static string dataDeleted = "Data telah dihapus.";
        public static string dataExist = "Data telah tersedia sebelumnya.";
        public static string datatNotExists = "Data tidak ditemukan.";

        public static string dataAdderror = "Gagal saat menambahkan data.";
        public static string daatUpdateError = "gagal saat mengubah data.";
        public static string somethingWentWrong = "Something went wrong, Please try again.";
        public static int success_code = 1;
        public static int failure_code = 0;

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
