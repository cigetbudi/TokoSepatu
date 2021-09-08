using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TokoSepatu.Models;
using TokoSepatu.Models.ViewModels;
using TokoSepatu.Utility;

namespace TokoSepatu.Controllers
{
    public class MerkController : Controller
    {
        private readonly ApplicationDbContext _db;
        public MerkController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            //LIST
            IEnumerable<Models.Merk> objList = _db.Merks;
            return View(objList);
        }

        public IActionResult Create()
        {
            return PartialView();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Merk obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _db.Merks.Add(obj);
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
            var obj = _db.Merks.Find(id);
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
            var obj = _db.Merks.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                _db.Merks.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        //GET Rubah
        public IActionResult Rubah(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var obj = _db.Merks.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return PartialView(obj);
        }

        //POST Rubah
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Rubah(Merk obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _db.Merks.Update(obj);
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
