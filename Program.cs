using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int sum = SumOfEvenNumbers(num);
            Console.WriteLine($"Sum of Even Numbers: {sum}");

        }
        #region
        public static int SumOfEvenNumbers(int num)
        {
            int sum = 0;
            for (int i = 2; i <= num; i += 2)
            {
                sum += i;
            }
            return sum;
        }
        #endregion

        #region

        // 2. Void method
        public static void PrintSumOfEvenNumbers(int num)
        {
            int sum = 0;
            for (int i = 2; i <= num; i += 2)
            {
                sum += i;
            }
            Console.WriteLine($"Sum of Even Numbers: {sum}");
        }
        #endregion
    }
}



    


