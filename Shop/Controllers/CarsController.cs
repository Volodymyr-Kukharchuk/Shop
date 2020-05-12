using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;

namespace Shop.Controllers
{
    [Controller]
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategoryes;

        public CarsController(IAllCars iallCars, ICarsCategory IcarCat)
        {
            _allCars = iallCars;
            _allCategoryes = IcarCat;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public IActionResult List(string category)
        {
            var _category = category;
            IEnumerable<Car> cars = null;
            var currCategory = string.Empty;
            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("Electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(c => c.Category.Name.Equals("Electro Cars")).OrderBy(i => i.Id);
                    currCategory = "Electro Cars";
                }
                else if (string.Equals("Fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(c => c.Category.Name.Equals("Classic Cars")).OrderBy(i => i.Id);
                    currCategory = "Classic Cars";
                }
            }

            var carObj = new CarsListViewModel
            {
                AllCars = cars,
                CurrCategory = currCategory
            };
            

            ViewBag.Title = "Page with cars";
            return View(carObj);
        }
    }
}
