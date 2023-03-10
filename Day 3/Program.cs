using System;
using System.IO;

namespace Day_3
{
    class Program
    {
        public static string[] rucksacks;
        public static string[] lowers = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
            "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
        public static string[] uppers = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P",
            "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
        static void Main(string[] args)
        {
            ReadFile();
            Calculate();
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
            string c1;
            string c2;
            for (int i = 0; i < rucksacks.Length; i++)
            {
                string sack = rucksacks[i];
                c1 = sack.Substring(0, sack.Length / 2);
                c2 = sack.Substring(sack.Length / 2);

                for (int j = 0; j < c1.Length; j++)
                {
                    string search = c1[j].ToString();
                    if (c2.Contains(search))
                    {
                        if (Char.IsUpper(c1[j]))
                            sum = sum + (Array.IndexOf(uppers, search) + 27);
                        else
                            sum = sum + (Array.IndexOf(lowers, search) + 1);
                        Console.WriteLine(sum);
                    }
                }
            }
            Console.WriteLine("The sum of the priorities is " + sum + "!");
        }
    }
}
