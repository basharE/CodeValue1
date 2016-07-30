using System;

namespace BinaryDisplay
{
    public class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine(CalcB(GetInput()));
            }
            catch (Exception e)
            {
                Console.WriteLine("\nMessage ---\n{0}", e.Message);
            }
            
        }

        private static int GetInput()
        {
            try
            {
                Console.WriteLine("please enter a number!!!");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                
                throw e;
            }
        }

        public static int CalcB(int num)
        { 
                if (num > -1)
                {
                    byte a, b = 1;
                    var count = 0;
                    while (num != 0)
                    {
                        a = (byte)(num % 2);
                        if ((byte)(a & b) == 1)
                            count++;
                        num = num >> 1;
                    }
                    return count;
                }
                throw new ArithmeticException();                       
        }
    }
}
