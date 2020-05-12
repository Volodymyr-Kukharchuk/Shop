using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class CategoryRepository:ICarsCategory
    {
        private readonly AppContextDataBase ContextDataBase;

        public CategoryRepository(AppContextDataBase appContextDataBase)
        {
            ContextDataBase = appContextDataBase;
        }

        public IEnumerable<Category> AllCategories => ContextDataBase.Category;
    }
}
