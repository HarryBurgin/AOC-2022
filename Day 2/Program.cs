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
            Calculate();
            Calculate2();
        }

        //Function that reads the text file containing the raw data
        static string[] ReadFile()
        {
            string txtFile = @"Data.txt";
            data = File.ReadAllLines(txtFile);

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
                me = data[i].Substring(2);
                if (me == "X")
                    score += 1;
                else if (me == "Y")
                    score += 2;
                else
                    score += 3;



                if ((elf == "A" && me == "X") | (elf == "B" && me == "Y") | (elf == "C" && me == "Z"))
                    score += 3;
                else if ((elf == "A" && me == "Y") | (elf == "B" && me == "Z") | (elf == "C" && me == "X"))
                {
                    score += 6;
                }
            }
            Console.WriteLine("Using the strategy guide, your score would be " + score + "!");
        }
        static void Calculate2()
        {
            int score = 0;
            string elf;
            string result;
            string me = "";
            for (int i = 0; i < data.Length; i++)
            {
                elf = data[i].Substring(0, 1);
                result = data[i].Substring(2);
                if (result == "X")
                {
                    if (elf == "A")
                        me = "Z";
                    else if (elf == "B")
                        me = "X";
                    else
                        me = "Y";
                }
                else if (result == "Y")
                {
                    score += 3;
                    if (elf == "A")
                        me = "X";
                    else if (elf == "B")
                        me = "Y";
                    else
                        me = "Z";
                }
                else if (result == "Z")
                {
                    score += 6;
                    if (elf == "A")
                        me = "Y";
                    else if (elf == "B")
                        me = "Z";
                    else
                        me = "X";
                }

                if (me == "X")
                    score += 1;
                else if (me == "Y")
                    score += 2;
                else
                    score += 3;


            }
            Console.WriteLine("Using the strategy guide, your score would be " + score + "!");
        }
    }
}
