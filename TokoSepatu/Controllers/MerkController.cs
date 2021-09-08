using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TokoSepatu.Models;

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
    }
}
