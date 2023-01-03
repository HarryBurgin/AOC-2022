using System;
using System.IO;

namespace AOC_D1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my solution for AOC 2022 Day 1");
            readFile();
        }

        static void readFile()
        {
            int[] initData = File.ReadAllLines(Data.txt);
            foreach (int output in initData)
                Console.WriteLine(output)
        }
    }
}
