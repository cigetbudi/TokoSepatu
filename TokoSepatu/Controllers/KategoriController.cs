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
    }
}
