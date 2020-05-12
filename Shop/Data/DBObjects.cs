using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppContextDataBase context)
        {


            if (!context.Category.Any())
            {
                context.Category.AddRange(Categories.Select(c => c.Value));
            }
            if (!context.Car.Any())
            {
                context.AddRange
                    (
                     new Car
                     {
                         Name = "Tesla",
                         ShortDesc = "ShortDesc Tesla",
                         LongDesc = "LongDesc Tesla",
                         Image = "/images/tesla.jpg",
                         Price = 45000,
                         IsFavorite = false,
                         Available = true,
                         Category = Categories["Electro Cars"]
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
                        Category = Categories["Classic Cars"]
                    },
                    new Car
                    {
                        Name = "Nissan",
                        ShortDesc = "ShortDesc Nissan",
                        LongDesc = "LongDesc Nissan",
                        Image = "/images/nissanGTR.jpg",
                        Price = 16000,
                        IsFavorite = false,
                        Available = true,
                        Category = Categories["Classic Cars"]
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
                        Category = Categories["Classic Cars"]
                    },
                    new Car
                    {
                        Name = "Audi",
                        ShortDesc = "ShortDesc Audi",
                        LongDesc = "LongDesc Audi",
                        Image = "/images/audi e-tron GT.jpg",
                        Price = 8900,
                        IsFavorite = false,
                        Available = true,
                        Category = Categories["Electro Cars"]
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
                        Category = Categories["Electro Cars"]
                    },
                    new Car
                    {
                        Name = "Nissan",
                        ShortDesc = "ShortDesc Nissan",
                        LongDesc = "LongDesc Nissan",
                        Image = "/images/nismoR-34.jpg",
                        Price = 8900,
                        IsFavorite = false,
                        Available = true,
                        Category = Categories["Classic Cars"]
                    },
                    new Car
                    {
                        Name = "Honda",
                        ShortDesc = "ShortDesc Honda",
                        LongDesc = "LongDesc Honda",
                        Image = "/images/honda s2000.jpg",
                        Price = 1900,
                        IsFavorite = false,
                        Available = true,
                        Category = Categories["Classic Cars"]
                    }
                    );
            }

            context.SaveChanges();
            
        }

        private static Dictionary<string, Category> _category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (_category == null)
                {
                    var list = new Category[]
                    {
                        new Category{Name = "Electro Cars", Description = "Novadays type of transport"},
                        new Category{Name = "Classic Cars", Description = "Esance engine cars"}
                    };
                    _category = new Dictionary<string, Category>();
                    foreach (var element in list)
                    {
                        _category.Add(element.Name, element);
                    }
                }

                return _category;
            }
        }

    }
}
