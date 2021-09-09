using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TokoSepatu.Models;
using TokoSepatu.Models.ViewModels;

namespace TokoSepatu.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            //LIST
            IEnumerable<Item> objList = _db.Items;
            //ngaduin ID expensetype ke expensetypeid expenses secara virtual
            foreach(var obj in objList)
            {
                obj.Kategori = _db.Kategoris.FirstOrDefault(i => i.Id == obj.KategoriId);
                obj.Merk = _db.Merks.FirstOrDefault(i => i.Id == obj.MerkId);
            }
            return View(objList);
        }
        //GET CREATE
        public IActionResult Create()
        {
            ItemViewModel itemViewModel = new ItemViewModel()
            {
                Item = new Item(),
                KategoriDropDown = _db.Kategoris.Select(o => new SelectListItem
                {
                    Text = o.Nama,
                    Value = o.Id.ToString()
                }),
                MerkDropDown = _db.Merks.Select(o => new SelectListItem
                {
                    Text = o.Nama,
                    Value = o.Id.ToString()
                })
            };
            return PartialView(itemViewModel);
        }

    }
}
