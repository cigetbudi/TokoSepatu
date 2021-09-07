using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TokoSepatu.Models.ViewModels
{
    public class ItemViewModel
    {
        public Item Item { get; set; }
        public IEnumerable<SelectListItem> KategoriDropDown { get; set; }
        public IEnumerable<SelectListItem> MerkDropDown { get; set; }
    }
}
