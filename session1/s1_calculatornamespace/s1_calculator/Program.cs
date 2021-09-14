using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MathLib.Calculator.Add(4 ,5));
            
            Console.WriteLine("--------------");
            int[] array = new int[]{1, 2, 3, 5};
            Console.WriteLine(MathLib.Calculator.Add(array));
        }
    }
}