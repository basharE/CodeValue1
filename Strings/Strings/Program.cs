using System;
using System.Collections.Generic;

namespace Strings
{
    public class Program
    {
        static void Main()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("please enter a sentence!!!");
                var sent = Console.ReadLine();
                flag = GetSen(sent);
            }
            SortDisply(null);
        }



        public static string ReverseString(string s)
        {
            var arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static bool GetSen(string input)
        {
            bool flag = !input.Equals("");
            if (input != null && flag)
            {
                var words = input.Split(' ');
                words = CheckSpace(words);
                Console.WriteLine("number of words is :" + words.Length);
                DisplyArr(words);
                SortDisply(words);
                return flag;
            }
            else
            {
                return flag;
            }

        }

        public static List<string> DisplyArr(string[] input)
        {
            List<string> s = new List<string>();
            for (var i = 0; i < input.Length; i++)
            {
                input[i] = ReverseString(input[i]);
                Console.WriteLine(input[i]);
                Console.WriteLine();
                s.Add(input[i]);
            }
            return s;
        }

        public static string[] SortDisply(string[] input)
        {
            Array.Sort(input);
            foreach (var word in input)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            return (string[])input;
        }

        private static string[] CheckSpace(string[] st)
        {
            List<string> sortBox1 = new List<string>(st);
            sortBox1.RemoveAll(string.IsNullOrWhiteSpace);           
            return sortBox1.ToArray();
        }
    }
}
