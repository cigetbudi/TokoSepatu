using TokoSepatu.Models;
using TokoSepatu.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TokoSepatu.Controllers
{
    public class AkunController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AkunController(ApplicationDbContext db)
        {
            _db = db;


        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

