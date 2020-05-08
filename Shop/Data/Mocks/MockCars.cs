using System;
using System.Collections.Generic;
using System.Linq;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        public readonly ICarsCategory CategoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                        {
                            Name = "Tesla",
                            ShortDesc ="ShortDesc Tesla",
                            LongDesc = "LongDesc Tesla",
                            Image = "/images/tesla.jpg",
                            Price = 45000,
                            IsFavorite = true,
                            Available = true,
                            Category = CategoryCars.AllCategories.First()
                        },
                    new Car
                    {
                    Name = "Ford Fiesta",
                    ShortDesc = "ShortDesc Ford Fiesta",
                    LongDesc = "LongDesc Ford Fiesta",
                    Image = "/images/tesla.jpg",
                    Price = 11000,
                    IsFavorite = true,
                    Available = true,
                    Category = CategoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        Name = "Nissan",
                        ShortDesc = "ShortDesc Nissan",
                        LongDesc = "LongDesc Nissan",
                        Image = "/images/nissanGTR.jpg",
                        Price = 16000,
                        IsFavorite = true,
                        Available = true,
                        Category = CategoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        Name = "BMW",
                        ShortDesc = "ShortDesc BMW",
                        LongDesc = "LongDesc BMW",
                        Image = "/images/BMW-M4.jpg",
                        Price = 14500,
                        IsFavorite = true,
                        Available = true,
                        Category = CategoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        Name = "Audi",
                        ShortDesc = "ShortDesc Audi",
                        LongDesc = "LongDesc Audi",
                        Image = "/images/audi e-tron GT.jpg",
                        Price = 8900,
                        IsFavorite = true,
                        Available = true,
                        Category = CategoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        Name = "BMW",
                        ShortDesc = "ShortDesc BMW",
                        LongDesc = "LongDesc BMW",
                        Image = "/images/BMW-i8.jpg",
                        Price = 28900,
                        IsFavorite = true,
                        Available = true,
                        Category = CategoryCars.AllCategories.First()
                    },new Car
                    {
                        Name = "Nissan",
                        ShortDesc = "ShortDesc Nissan",
                        LongDesc = "LongDesc Nissan",
                        Image = "/images/nismoR-34.jpg",
                        Price = 8900,
                        IsFavorite = true,
                        Available = true,
                        Category = CategoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        Name = "Honda",
                        ShortDesc = "ShortDesc Honda",
                        LongDesc = "LongDesc Honda",
                        Image = "/images/honda s2000.jpg",
                        Price = 1900,
                        IsFavorite = true,
                        Available = true,
                        Category = CategoryCars.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> GetFavoritesCars { get; set; }
        public Car GetObjectCar(int carId)
        {
            throw new System.NotImplementedException();
        }
    }
}
