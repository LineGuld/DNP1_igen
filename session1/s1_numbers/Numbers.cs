using System;

namespace s1_numbers
{
    public class Numbers
    {

        public static void PrintEven(int max)
        {
            for (int i = 1; i <= max; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}