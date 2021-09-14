using System;

namespace s1_MoreMath.MathLib
{
    public class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(int[] integers)
        {
            int result = 0;
            
            foreach (int numbers in integers)
            {
                result += numbers;
            }

            return result;
        }

        public static void BiggestNumber()
        {
            Console.WriteLine("Please write a number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please write a second number");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
                Console.WriteLine(a);
            else
            {
                Console.WriteLine(b);
            }
            {
                
            }
        }
    }
}