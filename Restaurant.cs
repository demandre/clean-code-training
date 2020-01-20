namespace Restaurant
{
    using System;

    public interface IMeal
    {
        string mealType { get; set; }
        IDrink drink { get; set; }
        IDessert dessert { get; set; }
        string hasCoffee { get; set; }

        public float bill();
    }

    public class SandwichMeal : IMeal
    {
        public string mealType { get; set; }
        public IDrink drink { get; set; }
        public IDessert dessert { get; set; }
        public string hasCoffee { get; set; }

        protected float price = 10;

        protected float standardMenuPrice = 13;
        protected float maxMenuPrice = 21;

        protected float coffeePrice = 1;

        /**
         *  Computes meal bill total
         *
         *  @return double total
         */
        public float bill()
        {
            float total = 0;

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

        protected float price = 15;

        protected float standardMenuPrice = 18;
        protected float maxMenuPrice = 21;
        protected float coffeePrice = 1;

        /**
         *  Computes meal bill total
         *
         *  @return double total
         */
        public float bill()
        {
            float total = 0;

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
        const float price = 0;

        public float getPrice() {
            return IDrink.price;
        }
    } 
    
    public class PetitDrink : IDrink{
        const float price = 2; 

    }
    public class MoyenDrink : IDrink{
        const float price = 3; 

    }
    public class GrandDrink : IDrink{
        const float price = 4; 
    }


    public interface IDessert
    {
        const float price = 0;

        public float getPrice() {
            return IDessert.price;
        }
    } 
    
    public class NormalDessert : IDessert{
        const float price = 2; 
    }
    public class SpecialDessert : IDessert{
        const float price = 4; 
    }
}