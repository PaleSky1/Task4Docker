using Microsoft.AspNetCore.Mvc;
using Task4DockerMVC.Models;
using System.Collections.Generic;

namespace Task4DockerMVC.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            var mockData = new List<Store>
            {
                new Store { StoreID = 1, StoreName = "Store 1", BrandID = 1, EnergyDrinkID = 1 },
                new Store { StoreID = 2, StoreName = "Store 2", BrandID = 2, EnergyDrinkID = 2 }
            };

            return View(mockData);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
