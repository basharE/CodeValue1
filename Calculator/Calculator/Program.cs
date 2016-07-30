using System;

namespace Calculator
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter two numbers :");
            var firstN = double.Parse(Console.ReadLine());
            var seconedN = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Please enter operator :");
            if (!CheckOp(firstN,seconedN, Console.ReadLine()))
            {
                Console.WriteLine("Operator is wrong !!!");
            }         
        }

        public static bool CheckOp(double num1, double num2,string op)
        {
            if (op == "+" || op == "-" || op == "*" || op == "/")
            {
                Console.WriteLine("the result is : " + Calc(num1, num2, op));
                return true;
            }
            return false;
        }

        public static double Calc(double num1, double num2, string op)
        {           
            switch (op)
            {
                case "+":
                    return num1 + num2;                   
                case "-":
                    return num1 - num2;                                    
                case "*":
                    return num1 * num2;                                     
                default:
                    return num1 / num2;                                                
            }
        }
    }
}
