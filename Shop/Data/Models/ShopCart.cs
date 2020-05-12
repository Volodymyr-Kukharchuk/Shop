using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Shop.Data.Models
{
    public class ShopCart
    {
        public string ShopCartId { get; set; }
        public IEnumerable<ShopCartItem> ListShopItems { get; set; }
        private readonly AppContextDataBase ContextDataBase;

        public ShopCart(AppContextDataBase appContextDataBase)
        {
            ContextDataBase = appContextDataBase;
        }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppContextDataBase>();
            var shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", shopCartId);
            return  new ShopCart(context){ShopCartId = shopCartId};
        }

        public void AddToCart(Car car)
        {
            ContextDataBase.ShopCartItem.Add(new ShopCartItem()
            {
                ShopCarId = ShopCartId,
                Car = car,
                Price = car.Price
            });
            ContextDataBase.SaveChanges();
        }

        public List<ShopCartItem> GetShopItems()
        {
            return ContextDataBase.ShopCartItem.Where(c => c.ShopCarId == ShopCartId).Include(s => s.Car).ToList(); 
        }
    }
}
