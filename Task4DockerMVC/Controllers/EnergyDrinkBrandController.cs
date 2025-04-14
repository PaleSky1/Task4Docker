using Microsoft.AspNetCore.Mvc;
using Task4DockerMVC.Models;
using System.Collections.Generic;

namespace Task4DockerMVC.Controllers
{
    public class EnergyDrinkBrandController : Controller
    {
        public IActionResult Index()
        {
            var mockData = new List<EnergyDrinkBrand>
            {
                new EnergyDrinkBrand { BrandID = 1, BrandName = "Red Bull" },
                new EnergyDrinkBrand { BrandID = 2, BrandName = "Monster" }
            };

            return View(mockData);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
