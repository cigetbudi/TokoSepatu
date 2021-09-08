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
    }
}
