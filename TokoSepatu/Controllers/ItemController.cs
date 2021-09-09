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
        //POST CREATE
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(ItemViewModel obj)
        {
            if (ModelState.IsValid)
            {
                _db.Items.Add(obj.Item);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(obj);
            }
        }

        //GET HAPUS
        public IActionResult Hapus(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _db.Items.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return PartialView(obj);
        }
       
        //POST DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult HapusPost(int? id)
        {
            var obj = _db.Items.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                _db.Items.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public IActionResult Rubah(int? id)
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
            if (id==null)
            {
                return NotFound();
            }

            itemViewModel.Item = _db.Items.Find(id);
            if (itemViewModel.Item == null)
            {
                return NotFound();
            }
            return PartialView(itemViewModel);
        }
    }
}
