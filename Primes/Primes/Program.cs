using System;
using System.Collections;


namespace Primes
{
    class Program
    {
        static void Main()
        {
            int[] array = CalcPrimes(22,42);
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }

        static int[] CalcPrimes(int a, int b)
        {
            ArrayList list = new ArrayList();
            while (a<=b)
            {
                if (IsPrime(a))
                    list.Add(a);
                a++;
            }
            int[] array = new int[list.Count];
            list.CopyTo(array);
            return array;
        }

        private static bool IsPrime(int number)
        {
            int boundary = (int)Math.Floor(Math.Sqrt(number));

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
