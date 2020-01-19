namespace cleancode
{
    using System;
    
    public class Restaurant
    {

        /**
         *  Computes meal billing with given meal options
         */
        public double MealBilling(string mealType, string customerName, string drinkSize, string dessertType, string hasCoffee)
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

            //le type ne peut être vide car le client doit déclarer au moins un repas
            // Functionnal rule? we're letting it in case of
            if(string.IsNullOrEmpty(mealType+customerName)) return -1;

            if(mealType=="assiette")
            {
                total+=assiettePrice;
                switch(drinkSize)
                {
                    case "petit":
                        total+=petitDrinkPrice;
                        if(dessertType=="normal")
                        {
                            total+=normalDessertPrice;
                        } else if(dessertType=="special"){
                            total+=specialDessertPrice;
                        }
                        break;
                    case "moyen":
                        total+=moyenDrinkPrice;
                        if(dessertType=="normal")
                        {
                            Console.Write("Prix Formule Standard appliquée\n");
                            total=assietteStandardMenuPrice;
                        } else if(dessertType=="special"){
                            total+=specialDessertPrice;
                        }
                        break;
                    case "grand":
                        total+=grandDrinkPrice;
                        if(dessertType=="normal")
                        {
                            total+=normalDessertPrice;
                        } else if(dessertType=="special"){
                            Console.Write("Prix Formule Max appliquée\n");
                            total=assietteMaxMenuPrice;
                        }
                        break;
                }
            }
            else if(mealType=="sandwich"){
                total+=sandwichPrice;
                switch(drinkSize)
                {
                    case "petit":
                        total+=petitDrinkPrice;
                        if(dessertType=="normal")
                        {
                            total+=normalDessertPrice;
                        } else if(dessertType=="special"){
                            total+=specialDessertPrice;
                        }
                        break;
                    case "moyen":
                        total+=moyenDrinkPrice;
                        if(dessertType=="normal")
                        {
                            Console.Write("Prix Formule Standard appliquée\n");
                            total=sandwichStandardMenuPrice;
                        } else if(dessertType=="special"){
                            total+=specialDessertPrice;
                        }
                        break;
                    case "grand":
                        total+=grandDrinkPrice;
                        if(dessertType=="normal")
                        {
                            total+=normalDessertPrice;
                        } else if(dessertType=="special"){
                            Console.Write("Prix Formule Max appliquée\n");
                            total=sandwichMaxMenuPrice;
                        }
                        break;
                }
            }
            if(mealType=="assiette" && drinkSize=="moyen" && dessertType=="normal" && hasCoffee=="yes")
            {
                Console.Write("Café offert!\n");
            } else {
                total+=coffeePrice;
            }
            return total;
        }
    }
}