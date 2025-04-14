using Microsoft.AspNetCore.Mvc;
using Task4DockerMVC.Models;
using System.Collections.Generic;

namespace Task4DockerMVC.Controllers
{
    public class EnergyDrinksController : Controller
    {
        public IActionResult Index()
        {
            var mockData = new List<EnergyDrinks>
            {
                new EnergyDrinks { EnergyDrinksID = 1, Brand = "Red Bull", Flavour = "Original", VolumeML = 250, Price = 2.5M, DeliveryDateTime = DateTime.Now },
                new EnergyDrinks { EnergyDrinksID = 2, Brand = "Monster", Flavour = "Green", VolumeML = 500, Price = 3.0M, DeliveryDateTime = DateTime.Now }
            };

            return View(mockData);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
