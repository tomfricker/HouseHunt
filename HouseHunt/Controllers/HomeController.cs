using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HouseHunt.Models;
using HouseHunt.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace HouseHunt.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        private readonly IHouseRepository _houseRepository;

        public HomeController(IHouseRepository houseRepository)
        {
            _houseRepository = houseRepository;
        }

        public IActionResult Index()
        {
            var houses = _houseRepository
                .GetAllHouses()
                .Where(h => h.WhenSeen <= DateTime.Now)
                .OrderByDescending(h => h.WhenSeen);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Houses we've seen",
                Houses = houses.ToList()
            };

            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var house = _houseRepository.GetHouseById(id);
            if (house == null)
            {
                return NotFound();
            }

            return View(house);
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
}
