namespace cleancode
{
    using System;
    
    public class Restaurant
    {

        /**
         *  Computes meal billing with given meal options
         */
        public double MealBilling(string mealType, string drinkSize, string dessertType, string hasCoffee)
        {
            int total = 0;

            int assiettePrice = 15;
            int sandwichPrice = 10;

            int petitDrinkPrice = 2;
            int moyenDrinkPrice = 3;
            int grandDrinkPrice = 4;

            int normalDessertPrice = 2;
            int specialDessertPrice = 4;

            int assietteStandardMenuPrice = 18;
            int assietteMaxMenuPrice = 21;

            int sandwichStandardMenuPrice = 13;
            int sandwichMaxMenuPrice = 21;

            int coffeePrice = 1;

            if(mealType=="assiette" && drinkSize=="moyen" && dessertType=="normal") {
                Console.Write("Assiette Formule Standard appliquée\n");
                total=assietteStandardMenuPrice;
                if(hasCoffee=="yes") {
                    Console.Write("Café offert!\n");
                }
                return total;
            }
            if(mealType=="assiette" && drinkSize=="grand" && dessertType=="special") {
                Console.Write("Assiette Formule Max appliquée\n");
                total=assietteMaxMenuPrice;
                return total;
            }

            if(mealType=="sandwich" && drinkSize=="moyen" && dessertType=="normal") {
                Console.Write("Sandwich Formule Standard appliquée\n");
                total=sandwichStandardMenuPrice;
                return total;
            }
            if(mealType=="sandwich" && drinkSize=="grand" && dessertType=="special") {
                Console.Write("Sandich Formule Max appliquée\n");
                total=sandwichMaxMenuPrice;
                return total;
            }

            Console.Write("Aucune Formule applicable\n");


            switch(mealType)
            {
                case "assiette":
                    total+=assiettePrice;
                    break;
                case "sandwich":
                    total+=sandwichPrice;
                    break;
                default:
                    Console.Write("Aucun repas commandé, erreur\n");
                    return -1;
            }

            switch(drinkSize)
            {
                case "petit":
                    total+=petitDrinkPrice;
                    break;
                case "moyen":
                    total+=moyenDrinkPrice;
                    break;
                case "grand":
                    total+=grandDrinkPrice;
                    break;
            }

            switch(dessertType)
            {
                case "normal":
                    total+=normalDessertPrice;
                    break;
                case "special":
                    total+=specialDessertPrice;
                    break;
            }

            if(hasCoffee == "yes") {
                total+=coffeePrice;
            }
            
            return total;
        }
    }
}