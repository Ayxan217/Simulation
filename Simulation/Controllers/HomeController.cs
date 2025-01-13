using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Simulation.DAL;

namespace Simulation.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View();
        }

    
    }
}
