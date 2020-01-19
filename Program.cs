using System;
using static cleancode.Restaurant;

namespace cleancode
{
   class Program
    {
        static void Main(string[] args)
        {
            cleancode.Restaurant restaurant = new cleancode.Restaurant();
            double invoice = restaurant.MealBilling("1","1","1","1","1","1","1");
            Console.WriteLine(invoice);
        }
    }
}
