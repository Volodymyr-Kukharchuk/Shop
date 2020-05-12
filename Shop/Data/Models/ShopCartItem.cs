namespace Shop.Data.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        public int Price { get; set; }
        public string ShopCarId { get; set; }

    }
}
