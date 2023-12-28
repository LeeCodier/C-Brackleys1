
using System;
using System.Collections.Generic;

namespace Arrays{
    class Program
    {
        static void Main(string[] args)
        {

        //     //Loop through a populated array

        //    string[] favourites = {
        //    "Pizza", //index 0
        //    "Burgers", //index 1
        //     "Hotdogs", //index 2
        //     "Sandwhich",
        //     "Calzone"
        //    };

        //    for (int i = 0; i < favourites.Length; i++)
        //    {
        //     int rank = i + 1;
        //     Console.WriteLine("Food " + rank + " ." + favourites[i]);
        //    }


    //     //Populate an empty array
    //     //the empty array can hold 4 elements
    //     //NB:you have to specify how many elements an empty array will hold
    //     string[] languages = new string[4];

    //     Console.WriteLine("Enter 4 Languages you wish to learn");
        
    //    for (int i = 0; i < languages.Length; i++)
    //    {
    //              languages[i] = Console.ReadLine();
    //    }

    //   Array.Sort(languages);

    //     Console.WriteLine("Here are those languages \n "); 

    //     for (int i = 0; i < languages.Length; i++)
    //     {
    //         Console.WriteLine( languages[i] );
    //      }



    //With a list, you dont need to specify 
         //a list needs a namespce with the 'using' keyword
        //a list is a generic
        List<string> shoppingList = new List<string>();
         
        //to add to a List
        shoppingList.Add("Milk");
        shoppingList.Add("Meat");
        shoppingList.Add("Veg");
        shoppingList.Add("Spices");
        //With lists you use '.Count' instead of .List
        for (int i = 0; i < shoppingList.Count; i++)
        {
         Console.WriteLine(shoppingList[i]);   
        }

        // //To remove to a List NB this would be removed if looped after the code
        // shoppingList.Remove("Milk");
        // shoppingList.RemoveAt(1);

           Console.ReadKey();
        }
    }
}