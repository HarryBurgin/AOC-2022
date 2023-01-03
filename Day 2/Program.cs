using System;
using System.IO;

namespace Day_2
{
    class Program
    {
        public static string[] data;
        static void Main(string[] args)
        {
            ReadFile();
        }

        //Function that reads the text file containing the raw data
        static string[] ReadFile()
        {
            string txtFile = @"Data.txt";
            data = File.ReadAllLines(txtFile);

            foreach (string line in data)
                Console.WriteLine(line);
            return data;
        }
    }
}
