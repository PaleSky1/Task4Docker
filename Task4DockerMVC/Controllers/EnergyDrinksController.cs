using Microsoft.AspNetCore.Mvc;
using Task4DockerMVC.Models;

namespace Task4DockerMVC.Controllers
{
    public class EnergyDrinksController : Controller
    {
        private readonly AppDbContext _context;

        public EnergyDrinksController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var drinks = _context.EnergyDrinks.ToList();
            return View(drinks);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EnergyDrinks drink)
        {
            if (ModelState.IsValid)
            {
                _context.EnergyDrinks.Add(drink);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(drink);
        }
    }
}