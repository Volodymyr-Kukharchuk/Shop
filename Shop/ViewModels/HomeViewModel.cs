using System.Collections.Generic;
using Shop.Data.Models;

namespace Shop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> FavCars { get; set; }
    }
}
