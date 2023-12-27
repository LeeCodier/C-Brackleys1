
using System;

namespace Variables{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Input a number: ");
           double num1 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Input a second number: ");
           double num2 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Input a third number: ");
           double num3 = Convert.ToDouble(Console.ReadLine());

         double result = (num1 + num2 + num3)/3;

           Console.WriteLine("The average of the  two is " + result);

           Console.ReadKey();
        }
    }
}