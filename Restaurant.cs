namespace cleancode
{
    using System;

    public interface IMeal
    {
        string mealType { get; set; }
        string drinkSize { get; set; }
        string dessertType { get; set; }
        string hasCoffee { get; set; }

        public double bill();
    }
    
    public class Meal : IMeal
    {
        public string mealType { get; set; }
        public string drinkSize { get; set; }
        public string dessertType { get; set; }
        public string hasCoffee { get; set; }

        protected int assiettePrice = 15;
        protected int sandwichPrice = 10;

        protected int petitDrinkPrice = 2;
        protected int moyenDrinkPrice = 3;
        protected int grandDrinkPrice = 4;

        protected int normalDessertPrice = 2;
        protected int specialDessertPrice = 4;

        protected int assietteStandardMenuPrice = 18;
        protected int assietteMaxMenuPrice = 21;

        protected int sandwichStandardMenuPrice = 13;
        protected int sandwichMaxMenuPrice = 21;

        protected int coffeePrice = 1;

        /**
         *  Computes meal billing with given meal options
         */
        public double bill()
        {
            int total = 0;

            if(this.mealType=="assiette" && this.drinkSize=="moyen" && this.dessertType=="normal") {
                Console.Write("Assiette Formule Standard appliquée\n");
                total=this.assietteStandardMenuPrice;
                if(this.hasCoffee=="yes") {
                    Console.Write("Café offert!\n");
                }
                return total;
            }
            if(this.mealType=="assiette" && this.drinkSize=="grand" && this.dessertType=="special") {
                Console.Write("Assiette Formule Max appliquée\n");
                total=this.assietteMaxMenuPrice;
                return total;
            }

            if(this.mealType=="sandwich" && this.drinkSize=="moyen" && this.dessertType=="normal") {
                Console.Write("Sandwich Formule Standard appliquée\n");
                total=this.sandwichStandardMenuPrice;
                return total;
            }
            if(this.mealType=="sandwich" && this.drinkSize=="grand" && this.dessertType=="special") {
                Console.Write("Sandich Formule Max appliquée\n");
                total=this.sandwichMaxMenuPrice;
                return total;
            }

            Console.Write("Aucune Formule applicable\n");


            switch(this.mealType)
            {
                case "assiette":
                    total+=this.assiettePrice;
                    break;
                case "sandwich":
                    total+=this.sandwichPrice;
                    break;
                default:
                    Console.Write("Aucun repas commandé, erreur\n");
                    return -1;
            }

            switch(this.drinkSize)
            {
                case "petit":
                    total+=this.petitDrinkPrice;
                    break;
                case "moyen":
                    total+=this.moyenDrinkPrice;
                    break;
                case "grand":
                    total+=this.grandDrinkPrice;
                    break;
            }

            switch(this.dessertType)
            {
                case "normal":
                    total+=this.normalDessertPrice;
                    break;
                case "special":
                    total+=this.specialDessertPrice;
                    break;
            }

            if(this.hasCoffee == "yes") {
                total+=this.coffeePrice;
            }
            
            return total;
        }
    }
}