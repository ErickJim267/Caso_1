using Caso_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Caso_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class ApplicationDbContext : ApplicationDbContext
    {
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Pasajero> Pasajeros { get; set }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options : base(options){

        }

    }
}
