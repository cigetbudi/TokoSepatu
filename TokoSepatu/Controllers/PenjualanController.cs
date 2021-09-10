using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TokoSepatu.Controllers
{
    public class PenjualanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
