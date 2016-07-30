using System;


namespace MulBoard
{
    class Program
    {
        static void Main()
        {
            int[,] array = Fill();
            PrintArr(array);
        }

        public static int[,] Fill()
        {
            Random random = new Random();       
            int[,] array = new int[10, 10];
            for (int i = 0; i < 10; ++i)
                for (int j = 0; j < 10; ++j)
                    array[i, j] = random.Next(0, 10000);
            return array;
        }

        public static void PrintArr(int[,] arr)
        {
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 10; ++j)
                    Console.Write(string.Format("{0,5}",arr[i, j].ToString()));
                Console.WriteLine();
            }
        }
    }
}

