using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TokoSepatu.Models;

namespace TokoSepatu.Controllers
{
    public class KategoriController : Controller
    {
        private readonly ApplicationDbContext _db;
        public KategoriController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Models.Kategori> objList = _db.Kategoris;
            return View(objList);
        }

        //GET Create
        public IActionResult Create()
        {
            return PartialView();
        }

        //POST CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Kategori obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _db.Kategoris.Add(obj);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }

            }
            catch (Exception)
            {

                ModelState.AddModelError("", "gagal saat menambah data");
            }
            return View(obj);

        }
        //GET HAPUS
        public IActionResult Hapus(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _db.Kategoris.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return PartialView(obj);
        }

        //POST HAPUS
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult HapusPost(int? id)
        {
            var obj = _db.Kategoris.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                _db.Kategoris.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        //GET Rubah
        public IActionResult Rubah(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _db.Kategoris.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return PartialView(obj);
        }
        //POST Rubah
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Rubah(Kategori obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _db.Kategoris.Update(obj);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }

            }
            catch (Exception)
            {

                ModelState.AddModelError("", "gagal saat mengdit data");
            }
            return View(obj);
        }
    }


}
