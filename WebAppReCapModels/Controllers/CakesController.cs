using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppReCapModels.Models;

namespace WebAppReCapModels.Controllers
{
    public class CakesController : Controller
    {
        ICakeService _cakeService;

        public CakesController(ICakeService cakeService)
        {
            _cakeService = cakeService;
        }

        public IActionResult Index()
        {
            return View(_cakeService.All());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CakeViewModel cake)
        {
            if (ModelState.IsValid)
            {
                _cakeService.Create(cake);
                return RedirectToAction("Index");
            }

            return View(cake);
        }
    }
}