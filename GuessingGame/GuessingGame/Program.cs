using System;

namespace GuessingGame
{
    class Program
    {
        static void Main()
        {
            Guess();
        }

        public static void Guess()
        {
            bool flag = false;
            int secret = new Random().Next(1, 101), num;
            for (int i = 0; i < 7 && flag == false; i++)
            {
                Console.WriteLine("guess the number: ");
                num = int.Parse(Console.ReadLine());
                if (num == secret)
                {
                    flag = true;
                    Console.WriteLine("you Won, within " + i + " guesses!!!");
                }
                else if (num > secret)
                {
                    Console.WriteLine("too big!!!");
                }
                else
                {
                    Console.WriteLine("too small!!!");
                }
            }
            if (!flag)
                Console.WriteLine("you failed, the correct number is :" + secret);
        }
    }
}
