using System;

namespace Basics{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Title = "1Basics";
          Console.ForegroundColor = ConsoleColor.DarkGreen;
          
    
          Console.WriteLine("Hello, whats your name?");
          Console.ReadLine();

         Console.WriteLine("I am a program \n Are you a program?");
         Console.ReadLine();

       Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Cool we are all different and thats ok");

          Console.ReadKey();
        }
    }
}