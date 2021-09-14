namespace ConsoleApp1.MathLib
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
    }
}