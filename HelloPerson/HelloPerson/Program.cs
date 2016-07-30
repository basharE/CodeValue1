using System;

namespace HelloPerson
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Please enter number :" );
            var num = Console.ReadLine();
            Display(Convert.ToInt32(num), name);
        }

        private static void Spaces(int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(" ");
        }

        public static void Display(int num,string name)
        {
            if (num > 0 && num < 11)
                for (int i = 0; i < num; i++)
                {
                    Spaces(i);
                    Console.WriteLine(name);
                }
            Console.WriteLine();
        }
    }
}
