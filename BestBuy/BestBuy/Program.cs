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

            Console.WriteLine(cork.Price + " "+ cork.Name + pricetax);
        }
        
    }
}
