using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TokoSepatu.Models;

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
    }
}
