using System.Collections.Generic;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockCategory:ICarsCategory
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{Name = "Electro Cars", Description = "Novadays type of transport"},
                new Category{Name = "Clasic Cars", Description = "Esance engine cars"}
            };
    }
}
