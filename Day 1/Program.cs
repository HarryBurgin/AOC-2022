using System;
using System.IO;

namespace AOC_D1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my solution for Day 1 of Advent Of Code 2022");
            readFile();
        }

        static void readFile()
        {
            string txtFile = @"Data.txt";
            string[] calories = File.ReadAllLines(txtFile);

            foreach (string line in calories)
                Console.WriteLine(line);

        }
    }
}
