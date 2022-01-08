using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BasicAuthentication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        { 
            return Ok("Index Page");
        }

        [Authorize]
        public IActionResult Secret()
        {
           return Ok("Secret");
        }
    }
}
