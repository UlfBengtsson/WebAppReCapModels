﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppReCapModels.Models;

namespace WebAppReCapModels.Controllers
{
    public class CarsController : Controller
    {
        CarService _carService = new CarService();
        public IActionResult Index()
        {
            return View(_carService.All());
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
    }
}