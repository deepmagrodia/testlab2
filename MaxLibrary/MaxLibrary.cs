/* Deep Magrodia
   Dr Yulia Kumar 
   Tech 4982 - 01
   Lab #2 */
using System;
namespace MaxNumberLib
{
    public class MaxNumber
    {
        public static double FindMaxTwo(double num1, double num2)
        {
            return Math.Max(num1, num2);
        }

        public static double FindMaxThree(double num1, double num2, double num3)
        {
            return Math.Max(Math.Max(num1, num2), num3);
        }
    }
}