namespace cleancode
{
    using System;
    
    public class Meal
    {
        string mealType;
        string drinkSize;
        string dessertType;
        string hasCoffee;
        public Meal(string mealType, string drinkSize, string dessertType, string hasCoffee) {
            this.mealType = mealType;
            this.drinkSize = drinkSize;
            this.dessertType = dessertType;
            this.hasCoffee = hasCoffee;
        }

        /**
         *  Computes meal billing with given meal options
         */
        public double bill()
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

            if(this.mealType=="assiette" && this.drinkSize=="moyen" && this.dessertType=="normal") {
                Console.Write("Assiette Formule Standard appliquée\n");
                total=assietteStandardMenuPrice;
                if(this.hasCoffee=="yes") {
                    Console.Write("Café offert!\n");
                }
                return total;
            }
            if(this.mealType=="assiette" && this.drinkSize=="grand" && this.dessertType=="special") {
                Console.Write("Assiette Formule Max appliquée\n");
                total=assietteMaxMenuPrice;
                return total;
            }

            if(this.mealType=="sandwich" && this.drinkSize=="moyen" && this.dessertType=="normal") {
                Console.Write("Sandwich Formule Standard appliquée\n");
                total=sandwichStandardMenuPrice;
                return total;
            }
            if(this.mealType=="sandwich" && this.drinkSize=="grand" && this.dessertType=="special") {
                Console.Write("Sandich Formule Max appliquée\n");
                total=sandwichMaxMenuPrice;
                return total;
            }

            Console.Write("Aucune Formule applicable\n");


            switch(this.mealType)
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

            switch(this.drinkSize)
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

            switch(this.dessertType)
            {
                case "normal":
                    total+=normalDessertPrice;
                    break;
                case "special":
                    total+=specialDessertPrice;
                    break;
            }

            if(this.hasCoffee == "yes") {
                total+=coffeePrice;
            }
            
            return total;
        }
    }
}