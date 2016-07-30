using System;

namespace DollarStairs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter a number please!!!");
            var number = Convert.ToInt32(Console.ReadLine());
            PrintDollarStairs(number);
        }


        public static void PrintDollar(int a)
        {
            while (a-- != 0)
                Console.Write("$");
        }

        public static void PrintSpace(int a)
        {
            while (a-- != 0)
                Console.Write(" ");
        }

        public static void PrintDollarStairs(int number)
        {
            for (var i = 1; i <= number; i++)
            {
                PrintDollar(i);
                PrintSpace(number - i);
                Console.WriteLine(" ");
            }
        }
    }
}
