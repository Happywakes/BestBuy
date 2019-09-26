using System;

namespace BestBuy
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Product cork = new Product();
            cork.Price = .10 ;
            cork.Name = "Brewing Corks ";

            double pricetax =  cork.PriceWithTax();

            Console.WriteLine("Base price: " + cork.Price + " Name: " + cork.Name + "Price with tax: " + pricetax);
        }
        
    }
}
