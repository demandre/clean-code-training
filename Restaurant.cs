namespace Restaurant
{
    using System;

    public interface IMeal
    {
        string mealType { get; set; }
        IDrink drink { get; set; }
        IDessert dessert { get; set; }
        string hasCoffee { get; set; }

        public double bill();
    }
    
    public class Meal : IMeal
    {
        // todo: class Assiette & class Sandwich 
        public string mealType { get; set; }
        public IDrink drink { get; set; }
        public IDessert dessert { get; set; }
        public string hasCoffee { get; set; }

        protected int assiettePrice = 15;
        protected int sandwichPrice = 10;

        protected int assietteStandardMenuPrice = 18;
        protected int assietteMaxMenuPrice = 21;

        protected int sandwichStandardMenuPrice = 13;
        protected int sandwichMaxMenuPrice = 21;

        protected int coffeePrice = 1;

        /**
         *  Computes meal bill total
         *
         *  @return double total
         */
        public double bill()
        {
            int total = 0;

            if(this.mealType=="assiette" && this.drink.GetType().Name == "MoyenDrink" && this.dessert.GetType().Name == "NormalDessert") {
                Console.Write("Assiette Formule Standard appliquée\n");
                total=this.assietteStandardMenuPrice;
                if(this.hasCoffee=="yes") {
                    Console.Write("Café offert!\n");
                }
                return total;
            }
            if(this.mealType=="assiette" && this.drink.GetType().Name == "GrandDrink" && this.dessert.GetType().Name == "SpecialDessert") {
                Console.Write("Assiette Formule Max appliquée\n");
                total=this.assietteMaxMenuPrice;
                return total;
            }

            if(this.mealType=="sandwich" && this.drink.GetType().Name == "MoyenDrink" && this.dessert.GetType().Name == "NormalDessert") {
                Console.Write("Sandwich Formule Standard appliquée\n");
                total=this.sandwichStandardMenuPrice;
                return total;
            }
            if(this.mealType=="sandwich" && this.drink.GetType().Name == "GrandDrink" && this.dessert.GetType().Name == "SpecialDessert") {
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

            total+=this.drink.getPrice();
            total+=this.dessert.getPrice();
           
            if(this.hasCoffee == "yes") {
                total+=this.coffeePrice;
            }
            
            return total;
        }
    }

    public interface IDrink
    {
        const int price = 0;

        public int getPrice() {
            return IDrink.price;
        }
    } 
    
    public class PetitDrink : IDrink{
        const int price = 2; 

    }
    public class MoyenDrink : IDrink{
        const int price = 3; 

    }
    public class GrandDrink : IDrink{
        const int price = 4; 
    }

    public interface IDessert
    {
        const int price = 0;

        public int getPrice() {
            return IDrink.price;
        }
    } 
    
    public class NormalDessert : IDessert{
        const int price = 2; 
    }
    public class SpecialDessert : IDessert{
        const int price = 4; 
    }
}