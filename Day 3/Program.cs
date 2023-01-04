using System;
using System.IO;

namespace Day_3
{
    class Program
    {
        public static string[] rucksacks;
        public static string c1;
        public static string c2;
        public static string[] lowers = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
            "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
        public static string[] uppers = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P",
            "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static string[] ReadFile()
        {
            string txtFile = @"data.txt";
            rucksacks = File.ReadAllLines(txtFile);

            return rucksacks;
        }

        static void Calculate()
        {
            int sum = 0;
            for (int i = 0; i < rucksacks.Length; i++)
            {
                string sack = rucksacks[i];
                c1 = sack.Substring(0, (sack.Length / 2) - 1);
                c2 = sack.Substring(sack.Length / 2);

                for (int j = 0; j < c1.Length; j++)
                {
                    if (c1[j] == c2[j])
                    {
                        if (Char.IsUpper(c1[j]))
                            sum += (Array.IndexOf(uppers, c1[j]) + 1);
                        else
                            sum += (Array.IndexOf(lowers, c1[j]) + 1);
                    }
                }
            }
        }
    }
}
