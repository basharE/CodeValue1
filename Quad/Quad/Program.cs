using System;

namespace Quad
{
    public class Program
    {
        static void Main()
        {
            double a, b, c;
            double.TryParse(Console.ReadLine(),out a);
            double.TryParse(Console.ReadLine(),out b);
            double.TryParse(Console.ReadLine(),out c);
            CalcQ(a, b, c);
        }

        public static int CalcQ(double a, double b, double c)
        {
            if (a==0)
            {
                if (b != 0)
                {
                    double res1 = -1 * (c) / (b);
                    Console.WriteLine("there's one solution and it is : " + res1);
                    return 1;
                }
                else 
                {
                    Console.WriteLine("ther's no solution!!!");
                    return 0;
                }                
            }
            else
            {
                var delta = ((b) * (b)) - (4 * (a) * (c));
                if (delta < 0)
                {
                    Console.WriteLine("ther's no solution!!!");
                    return 0;
                }
                else if (delta > 0)
                {
                    double res1 = (-1 * (b) + Math.Sqrt(delta)) / (2 * (a));
                    double res2 = (-1 * (b) - Math.Sqrt(delta)) / (2 * (a));
                    Console.WriteLine("there's two solutions first is : " + res1 + " ,second is : " + res2);
                    return 2;
                }
                else if (delta == 0)
                {
                    double res1 = -1 * (b) / (2 * (a));                  
                    Console.WriteLine("there's one solution and it is : " + res1);
                    return 1;                  
                }
                else
                {
                    return 0;
                }
            } 
        }
    }
}
