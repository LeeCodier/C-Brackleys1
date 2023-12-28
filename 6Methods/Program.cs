
using System;

namespace Methods{
    class Program
    {
        static void Main(string[] args)
        {
     //    MeetAlien();
           Console.WriteLine("PLease input a number to be sqaured");
           int input = Convert.ToInt32(Console.ReadLine());
           
           int returned = Square(input);

           Console.WriteLine(input +  " Squared is: " + returned);

         Console.ReadKey();
        }




    //method that returns things the return data type 'int' must be specified
   static int Square(int number)
    {
        int result = number * number;
        return result;
    }
      

    //    //Basic method 

    //    static void MeetAlien(){
    //     Random numberGen = new Random();

    //     string name = "X-" + numberGen.Next(1,100);
    //     int age = numberGen.Next(10,500);

    //     Console.WriteLine("Hi, I'm " + name);
    //     Console.WriteLine("I'm " + age + " years old");
    //    }
    }
}