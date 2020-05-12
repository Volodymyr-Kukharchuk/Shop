using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class HomeController:Controller
    {
        private IAllCars _carRep;
        public HomeController(IAllCars carRepository)
        {
            _carRep = carRepository;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                FavCars = _carRep.GetFavoritesCars
            };
            return View(homeCars);
        }
    }
}
