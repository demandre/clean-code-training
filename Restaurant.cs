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

            //le type ne peut être vide car le client doit déclarer au moins un repas
            // Functionnal rule? we're letting it in case of
            if(string.IsNullOrEmpty(mealType+customerName)) return -1;

            if(mealType=="assiette")
            {
                total+=15;
                switch(drinkSize)
                {
                    case "petit":
                        total+=2;
                        if(dessertType=="normal")
                        {
                            total+=2;
                        } else if(dessertType=="special"){
                            total+=4;
                        }
                        break;
                    case "moyen":
                        total+=3;
                        if(dessertType=="normal")
                        {
                            Console.Write("Prix Formule Standard appliquée\n");
                            total=18;
                        } else if(dessertType=="special"){
                            total+=4;
                        }
                        break;
                    case "grand":
                        total+=4;
                        if(dessertType=="normal")
                        {
                            total+=2;
                        } else if(dessertType=="special"){
                            Console.Write("Prix Formule Max appliquée\n");
                            total=21;
                        }
                        break;
                }
            }
            else if(mealType=="sandwich"){
                total+=10;
                switch(drinkSize)
                {
                    case "petit":
                        total+=2;
                        if(dessertType=="normal")
                        {
                            total+=2;
                        } else if(dessertType=="special"){
                            total+=4;
                        }
                        break;
                    case "moyen":
                        total+=3;
                        if(dessertType=="normal")
                        {
                            Console.Write("Prix Formule Standard appliquée\n");
                            total=13;
                        } else if(dessertType=="special"){
                            total+=4;
                        }
                        break;
                    case "grand":
                        total+=4;
                        if(dessertType=="normal")
                        {
                            total+=2;
                        } else if(dessertType=="special"){
                            Console.Write("Prix Formule Max appliquée\n");
                            total=16;
                        }
                        break;
                }
            }
            if(mealType=="assiette" && drinkSize=="moyen" && dessertType=="normal" && hasCoffee=="yes")
            {
                Console.Write("Café offert!\n");
            } else {
                total+=1;
            }
            return total;
        }
    }
}