using Microsoft.AspNetCore.Mvc;
using Task4DockerMVC.Models;

namespace Task4DockerMVC.Controllers
{
    public class StoreController : Controller
    {
        private readonly AppDbContext _context;

        public StoreController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var stores = _context.Stores.ToList();
            return View(stores);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Store store)
        {
            if (ModelState.IsValid)
            {
                _context.Stores.Add(store);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(store);
        }
    }
}