using System;
using System.IO;

namespace AOC_D1
{
    class Program
    {
        public static string[] data;
        public static int[] calories;
        static void Main(string[] args)
        {
            Console.WriteLine("This is my solution for Day 1 of Advent Of Code 2022");
            ReadFile();
            DataConversion();
            Calculate();
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

        static int[] DataConversion()
        {
            //string d;
            //int c;
            //for (int i = 0; i < data.Length; i++)
            //{
            //    if (data[i] == "")
            //        calories[i] = 0;
            //    else
            //    {
            //        d = data[i];
            //        c = Convert.ToInt32(d);
            //        calories[i] = c;
            //    }
            //}

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == "")
                    data[i] = "0";
            }

            calories = Array.ConvertAll(data, int.Parse);
            return calories;
        }

        static void Calculate()
        {
            int current = 0;
            int highestVal = 0;
            int highestElf = 0;
            for (int i = 0; i < calories.Length; i++)
            {
                if (calories[i] != 0)
                    current += calories[i];
                else if (current > highestVal)
                {
                    highestVal = current;
                    highestElf = i + 1;
                    current = 0;
                }
                else
                    current = 0;
            }
            Console.WriteLine("Elf " + highestElf + " had the most calories (" + highestVal + ")");
        }
    }
}
