
using System;

namespace Conditionals{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Welcome quizmaster, answer 5 questions\nyou must get at least 4 correct to win");
           Console.ReadKey();  

          int point = 0;
          
          Console.WriteLine("What is 2+4?");
          int q1 = Convert.ToInt32(Console.ReadLine());
          if (q1 == 6)
          {
           point++;
             Console.WriteLine("Correct");
             Console.WriteLine("You have: " + point + " point");
          }
          else 
          {
            Console.WriteLine("Wrong");
            Console.WriteLine("You have " + point + " point");
          }
          
          //Q2
          Console.WriteLine("What is 2+4?");
          int q2 = Convert.ToInt32(Console.ReadLine());
          if (q2 == 6)
          {
           point++;
             Console.WriteLine("Correct");
             Console.WriteLine("You have: " + point + " point");
          }
          else 
          {
            Console.WriteLine("Wrong");
            Console.WriteLine("You have " + point + " point");
          }

          //Q3
          Console.WriteLine("What is 10 times 2?");
          int q3 = Convert.ToInt32(Console.ReadLine());
          if (q3 == 20)
          {
           point++;
             Console.WriteLine("Correct");
             Console.WriteLine("You have: " + point + " point");
          }
          else 
          {
            Console.WriteLine("Wrong");
            Console.WriteLine("You have " + point + " point");
          }
          
          //Q4
          Console.WriteLine("What is 8*2?");
          int q4 = Convert.ToInt32(Console.ReadLine());
          if (q4 == 16)
          {
           point++;
             Console.WriteLine("Correct");
             Console.WriteLine("You have: " + point + " point");
          }
          else 
          {
            Console.WriteLine("Wrong");
            Console.WriteLine("You have " + point + " point");
          }

          //Q5
          Console.WriteLine("What is 5 times 3?");
          int q5 = Convert.ToInt32(Console.ReadLine());
          if (q5 == 15)
          {
           point++;
             Console.WriteLine("Correct");
             Console.WriteLine("You have: " + point + " point");
          }
          else 
          {
            Console.WriteLine("Wrong");
            Console.WriteLine("You have " + point + " point");
          }
           
         Console.WriteLine("Welldone press space to see your result");
         Console.ReadKey();

         if (point >= 4)
         {
            Console.WriteLine("Congrats you have " + point + " points \n YOU WIN!!");
         }
         else{
             Console.WriteLine("Sorry you have " + point + " points \n YOU LOOSE!!");

         }

         Console.ReadKey();
        }
    }
}