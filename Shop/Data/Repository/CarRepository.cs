using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class CarRepository:IAllCars
    {
        private readonly AppContextDataBase ContextDataBase;

        public CarRepository(AppContextDataBase appContextDataBase)
        {
            ContextDataBase = appContextDataBase;
        }

        public IEnumerable<Car> Cars => ContextDataBase.Car.Include(c => c.Category);
        public IEnumerable<Car> GetFavoritesCars => ContextDataBase.Car.Where(p => p.IsFavorite).Include(c => c.Category);
        public Car GetObjectCar(int carId) => ContextDataBase.Car.FirstOrDefault(id=>id.Id == carId);
    }
}
