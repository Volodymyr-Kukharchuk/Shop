using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;

namespace Shop.Controllers
{
    [Controller]
    public class CarsController:Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategoryes;

        public CarsController(IAllCars iallCars, ICarsCategory IcarCat)
        {
            _allCars = iallCars;
            _allCategoryes = IcarCat;
        }

        public IActionResult List()
        {
            ViewBag.Title = "Page with cars";
            CarsListViewModel obj = new CarsListViewModel();
            obj.AllCars = _allCars.Cars;
            obj.CurrCategory = "Cars";
            return View(obj);
        }
    }
}
