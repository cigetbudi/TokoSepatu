using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TokoSepatu.Models;

namespace TokoSepatu.Controllers
{
    public class PembeliController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PembeliController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            //List
            IEnumerable<Pembeli> objList = _db.Pembelis;
            return View(objList);
        }

        public IActionResult Create()
        {
            return PartialView();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create (Pembeli obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _db.Pembelis.Add(obj);
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
