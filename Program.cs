using System;
using static cleancode.Meal;

namespace cleancode
{
   class Program
    {
        static void Main(string[] args)
        {
            cleancode.Meal meal = new cleancode.Meal();
            meal.mealType="sandwich";
            meal.drinkSize="moyen";
            meal.dessertType="normal";
            meal.hasCoffee="yes";
            double invoice = meal.bill();
            Console.WriteLine(invoice);
            meal.mealType="1";
            meal.drinkSize="1";
            meal.dessertType="1";
            meal.hasCoffee="yes";
            invoice = meal.bill();
            Console.WriteLine(invoice);
        }
    }
}
