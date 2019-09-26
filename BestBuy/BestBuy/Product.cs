using System;
namespace BestBuy
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        
        public Product()
        {

        }

        public double PriceWithTax(double price)
        {
            Price = price;
            return price * 1.1;
        }
    }
}
