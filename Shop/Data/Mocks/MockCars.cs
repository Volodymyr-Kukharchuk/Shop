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
                            Image = "https://image.shutterstock.com/image-photo/toronto-ontario-canada-september-20th-260nw-1567950118.jpg",
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
                    Image = "https://www.carscoops.com/wp-content/uploads/2019/04/25ac5d75-ford-fiesta-st-performance-edition-00.jpg",
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
                        Image = "https://cdn.motor1.com/images/mgl/WxMJg/s3/liberty-walk-wants-to-sell-you-a-73-570-nissan-gt-r-body-kit.jpg",
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
                        Image = "https://www.autozeitung.de/assets/field/image/bmw-m4-vorsteiner-1.jpg",
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
                        Image = "https://audimediacenter-a.akamaihd.net/system/production/media/87433/images/46bb25600114b66450cc83368b626362f395ae8a/A1915306_x500.jpg?1582585953",
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
                        Image = "https://bmw.autoua.net/media/catalog/3/0/p1760430-1540551040.jpg",
                        Price = 28900,
                        IsFavorite = true,
                        Available = true,
                        Category = CategoryCars.AllCategories.First()
                    },new Car
                    {
                        Name = "Nissan",
                        ShortDesc = "ShortDesc Nissan",
                        LongDesc = "LongDesc Nissan",
                        Image = "https://speedhunters-wp-production.s3.amazonaws.com/wp-content/uploads/2019/02/28092226/trust_r34_gtr_dino_dalle_carbonare_23.jpg",
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
                        Image = "https://car-images.bauersecure.com/pagefiles/83707/080_s2000.jpg",
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
