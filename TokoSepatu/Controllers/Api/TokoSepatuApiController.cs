using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TokoSepatu.Controllers.Api
{
    [Route("api/TokoSepatu")]
    [ApiController]
    public class TokoSepatuApiController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string loginUserId;
        private readonly string role;

        public TokoSepatuApiController(IHttpContextAccessor httpContextAccessor) 
        {
            loginUserId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            role = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
        }
        public IActionResult Index()
        {
            return View();
        }

    }

}
