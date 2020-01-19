namespace cleancode
{
    using System;

    public class Restaurant
    {

        //calcule le prix payé par l'utilisateur dans le restaurant, en fonction de type de
        //repas qu'il prend (assiette ou sandwich), de la taille de la boisson (petit, moyen, grand), du dessert et
        //de son type (normal ou special) et si il prend un café ou pas (yes ou no).
        //les prix sont fixes pour chaque type de chose mais des réductions peuvent s'appliquer
        //si cela rentre dans une formule!
        public double MealBilling(string type, string name, string beverage, string size, string dessert, string dsize, string coffee)
        {
            int total = 0;

            //le type ne peut être vide car le client doit déclarer au moins un repas
            if(string.IsNullOrEmpty(type+name)) return -1;

            if(type=="assiette")
            {
                total+=15;
                //ainsi qu'une boisson de taille:
                switch(size)
                {
                    case "petit":
                        total+=2;
                        if(dsize=="normal")
                        {
                            //on ajoute le prix du dessert normal
                            total+=2;
                        } else {
                            //sinon on rajoute le prix du dessert special
                            total+=4;
                        }
                        break;
                    case "moyen":
                        total+=3;
                        if(dsize=="normal")
                        {
                            Console.Write("Prix Formule Standard appliquée ");
                            total=18;
                        } else {
                            //sinon on rajoute le prix du dessert special
                            total+=4;
                        }
                        break;
                    case "grand":
                        total+=4;
                        if(dsize=="normal")
                        {
                            //on ajoute le prix du dessert normal
                            total+=2;
                        } else {
                            Console.Write("Prix Formule Max appliquée ");
                            total=21;
                        }
                        break;
                }
            }
            //mode sandwich
            else {
                total+=10;
                //ainsi qu'une boisson de taille:
                switch(size)
                {
                    case "petit":
                        total+=2;
                        if(dsize=="normal")
                        {
                            //on ajoute le prix du dessert normal
                            total+=2;
                        } else {
                            //sinon on rajoute le prix du dessert special
                            total+=4;
                        }
                        break;
                    case "moyen":
                        total+=3;
                        if(dsize=="normal")
                        {
                            Console.Write("Prix Formule Standard appliquée ");
                            total=13;
                        } else {
                            //sinon on rajoute le prix du dessert special
                            total+=4;
                        }
                        break;
                    case "grand":
                        total+=4;
                        if(dsize=="normal")
                        {
                            //on ajoute le prix du dessert normal
                            total+=2;
                        } else {
                            Console.Write("Prix Formule Max appliquée ");
                            total=16;
                        }
                        break;
                }
            }
            if(type=="assiette" && size=="moyen" && dsize=="normal" && coffee=="yes")
            {
                Console.Write(" avec café offert!");
            } else {
                total+=1;
            }
            return total;
        }
    }
}