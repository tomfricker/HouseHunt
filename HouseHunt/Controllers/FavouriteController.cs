using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseHunt.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseHunt.Controllers
{
    [Authorize]
    public class FavouriteController : Controller
    {
        IHouseRepository _houseRepository;

        public FavouriteController(IHouseRepository houseRepository)
        {
            _houseRepository = houseRepository;
        }

        public IActionResult Index()
        {
            var favourite = _houseRepository.GetFavourite();

            return View(favourite);
        }
    }
}