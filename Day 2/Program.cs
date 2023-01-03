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

        static void Calculate()
        {
            int score = 0;
            string elf;
            string me;
            for (int i = 0; i < data.Length; i++)
            {
                elf = data[i].Substring(0, 1);
                me = data[i].Substring(1);
                if (me == "X")
                    score += 1;
                else if (me == "Y")
                    score += 2;
                else
                    score += 3;
            }
        }
    }
}
