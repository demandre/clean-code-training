using System;
using Restaurant;

namespace cleancode
{
   class Program
    {
        static void Main(string[] args)
        {
            Restaurant.Meal meal = new Restaurant.Meal();
            meal.mealType="sandwich";
            meal.drink=new Restaurant.MoyenDrink();
            meal.dessert=new Restaurant.NormalDessert();
            meal.hasCoffee="yes";
            double invoice = meal.bill();
            Console.WriteLine(invoice);

            meal.mealType="1";
            meal.drink = new Restaurant.PetitDrink();
            meal.dessert = new Restaurant.SpecialDessert();
            meal.hasCoffee="yes";
            invoice = meal.bill();
            Console.WriteLine(invoice);
        }
    }
}
