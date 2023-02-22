/* Deep Magrodia
   Dr Yulia Kumar 
   Tech 4982 - 01
   Lab #2 */

using System;
using MaxNumberLib;

namespace MaxTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First number :");
                double num1=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number :");
                double num2 = double.Parse(Console.ReadLine());
             
            double max = MaxNumber.FindMaxTwo(num1, num2);
            Console.WriteLine("The maximum of {0} and {1} is {2}", num1, num2, max);
            Console.WriteLine("Enter the Third number :");
            double num3 = double.Parse(Console.ReadLine());

            double max2 = MaxNumber.FindMaxThree(num1, num2, num3);
            Console.WriteLine("The maximum of {0} {1} {2} is {3}", num1, num2, num3, max2);



        }
    }
}