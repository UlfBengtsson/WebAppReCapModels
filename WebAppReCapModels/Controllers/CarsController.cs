using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppReCapModels.Models;

namespace WebAppReCapModels.Controllers
{
    public class CarsController : Controller
    {
        readonly CarService _carService = new CarService();
        public IActionResult Index()
        {
            return View(_carService.All());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CarViewModel car)
        {
            if (ModelState.IsValid)
            {
                _carService.Create(car.Brand, car.ModelName);
                return RedirectToAction("Index");
            }
            return View(car);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Car car = _carService.Find(id);

            if (car == null)
            {
                ViewBag.msg = "Car was not found.";
                return View("Index", _carService.All());
            }

            return View(car);
        }

        [HttpPost]
        public IActionResult Edit(Car car)
        {
            if (ModelState.IsValid)
            {
                _carService.Update(car);

                return RedirectToAction("Index");
            }

            return View(car);
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            bool result = _carService.Remove(id);

            if (result)
            {
                ViewBag.msg = "Car has bin removed.";
            }
            else
            {
                ViewBag.msg = "Unable to remove car.";
            }

            return View("Index", _carService.All());
        }

        public IActionResult CarList()// Will use Partical views in this list
        {
            return View(_carService.All());
        }
    }
}