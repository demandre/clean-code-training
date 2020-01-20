using System;
using static cleancode.Meal;

namespace cleancode
{
   class Program
    {
        static void Main(string[] args)
        {
            cleancode.Meal meal = new cleancode.Meal("sandwich","moyen","normal","yes");
            double invoice = meal.bill();
            Console.WriteLine(invoice);
            meal = new cleancode.Meal("1","1","1","yes");
            invoice = meal.bill();
            Console.WriteLine(invoice);

        }
    }
}
