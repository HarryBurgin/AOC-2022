using System;
using System.IO;

namespace Day_3
{
    class Program
    {
        public static string[] rucksacks;
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
    }
}
