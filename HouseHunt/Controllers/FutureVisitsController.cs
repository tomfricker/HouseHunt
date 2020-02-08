using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using HouseHunt.Models;
using HouseHunt.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HouseHunt.Controllers
{
    //[Authorize]
    public class FutureVisitsController : Controller
    {
        private readonly IHouseRepository _houseRepository;
        private readonly IPictureRepository _pictureRepository;

        public FutureVisitsController(IHouseRepository houseRepository, IPictureRepository pictureRepository)
        {
            _houseRepository = houseRepository;
            _pictureRepository = pictureRepository;
        }

        public IActionResult Index()
        {
            var houses = _houseRepository
                .GetAllHouses()
                .Where(h => h.WhenSeen > DateTime.Now)
                .OrderBy(h => h.WhenSeen);

            var futureVisitsViewModel = new FutureVisitsViewModel()
            {
                Title = "Houses we're seeing",
                Houses = houses.ToList()
            };

            return View(futureVisitsViewModel);
        }

        public IActionResult Details(int id)
        {
            var house = _houseRepository.GetHouseById(id);
            if (house == null)
            {
                return NotFound();
            }

            var pictures = _pictureRepository.GetAllPicturesForHouse(id);

            var viewModel = new DetailsViewModel()
            {
                House = house,
                Pictures = pictures,
            };

            return View(viewModel);
        }

        // GET: AddHouse/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddHouse/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(House house)
        {
            _houseRepository.AddHouse(house);

            return RedirectToAction("Index");
        }

        // GET: AddHouse/Create
        public ActionResult AddPicture(int houseId)
        {
            var picture = new Picture(){HouseId = houseId};
            return View(picture);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddPicture(Picture picture)
        {
            _houseRepository.AddPicture(picture);

            return RedirectToAction("Details", new {id = picture.HouseId});
        }

        public ActionResult Delete(int houseId)
        {
            return View(new DeleteViewModel(){HouseId = houseId});
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteHouse(int houseId)
        {
            _houseRepository.Delete(houseId);

            return RedirectToAction("Index", "Home");
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int houseId)
        {
            var house = _houseRepository.GetHouseById(houseId);
            
            return View(house);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(House house)
        {
            var editedHouse = _houseRepository.EditHouse(house);

            return View(editedHouse);
        }
    }
}