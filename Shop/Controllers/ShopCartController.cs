using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.Data.Repository;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class ShopCartController:Controller
    {
        private IAllCars _carRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllCars carRepository,ShopCart shopCart)
        {
            _carRep = carRepository;
            shopCart = _shopCart;
        }

        public ViewResult Index()
        {
            //var items = _shopCart.GetShopItems();
            //_shopCart.ListShopItems = items;
            var obj = new ShopCartViewModel {ShopCart = _shopCart};
            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _carRep.Cars.FirstOrDefault(c => c.Id == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }
    }
}
