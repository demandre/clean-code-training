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

    public class SandwichMeal : IMeal
    {
        public string mealType { get; set; }
        public IDrink drink { get; set; }
        public IDessert dessert { get; set; }
        public string hasCoffee { get; set; }

        protected int price = 10;

        protected int standardMenuPrice = 13;
        protected int maxMenuPrice = 21;

        protected int coffeePrice = 1;

        /**
         *  Computes meal bill total
         *
         *  @return double total
         */
        public double bill()
        {
            int total = 0;

            if(this.hasCoffee == "yes") {
                total+=this.coffeePrice;
            }

            if(this.drink.GetType().Name == "MoyenDrink" && this.dessert.GetType().Name == "NormalDessert") {
                Console.Write("Sandwich Formule Standard appliquée\n");
                total+=this.standardMenuPrice;
                return total;
            }

            if(this.drink.GetType().Name == "GrandDrink" && this.dessert.GetType().Name == "SpecialDessert") {
                Console.Write("Sandwich Formule Max appliquée\n");
                total+=this.maxMenuPrice;
                return total;
            }

            total+=this.price;
            total+=this.drink.getPrice();
            total+=this.dessert.getPrice();
            
            return total;
        }
    }

    public class AssietteMeal : IMeal
    {
        public string mealType { get; set; }
        public IDrink drink { get; set; }
        public IDessert dessert { get; set; }
        public string hasCoffee { get; set; }

        protected int price = 15;

        protected int standardMenuPrice = 18;
        protected int maxMenuPrice = 21;
        protected int coffeePrice = 1;

        /**
         *  Computes meal bill total
         *
         *  @return double total
         */
        public double bill()
        {
            int total = 0;

            if(this.hasCoffee == "yes") {
                total+=this.coffeePrice;
            }

            if(this.drink.GetType().Name == "MoyenDrink" && this.dessert.GetType().Name == "NormalDessert") {
                Console.Write("Assiette Formule Standard appliquée\n");
                if(this.hasCoffee=="yes") {
                    Console.Write("Café offert!\n");
                }
                total=this.standardMenuPrice;
                return total;
            }

            if(this.drink.GetType().Name == "GrandDrink" && this.dessert.GetType().Name == "SpecialDessert") {
                Console.Write("Assiette Formule Max appliquée\n");
                total+=this.maxMenuPrice;
                return total;
            }

            total+=this.price;
            total+=this.drink.getPrice();
            total+=this.dessert.getPrice();
            
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
            return IDessert.price;
        }
    } 
    
    public class NormalDessert : IDessert{
        const int price = 2; 
    }
    public class SpecialDessert : IDessert{
        const int price = 4; 
    }
}