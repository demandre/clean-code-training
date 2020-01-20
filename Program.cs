using System;
using Restaurant;

namespace cleancode
{
   class Program
    {
        static void Main(string[] args)
        {
            Restaurant.IMeal sandwichMeal = new Restaurant.SandwichMeal();
            sandwichMeal.drink = new Restaurant.MoyenDrink();
            sandwichMeal.dessert = new Restaurant.SpecialDessert();
            sandwichMeal.hasCoffee = true;
            float invoice = sandwichMeal.bill();
            Console.WriteLine(invoice);

            Restaurant.IMeal assietteMeal = new Restaurant.AssietteMeal();
            assietteMeal.drink = new Restaurant.MoyenDrink();
            assietteMeal.dessert = new Restaurant.NormalDessert();
            assietteMeal.hasCoffee = true;
            invoice = assietteMeal.bill();
            Console.WriteLine(invoice);
        }
    }
}
