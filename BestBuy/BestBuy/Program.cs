using System;

namespace BestBuy
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Product cork = new Product();
            
            cork.Name = "Brewing Corks ";

            

            Console.WriteLine( "Name: " + cork.Name + " Price with tax: " + cork.PriceWithTax(.10) + " Base price: " + cork.Price);
        }
        
    }
}
