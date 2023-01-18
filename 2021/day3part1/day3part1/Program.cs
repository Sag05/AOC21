using System;
using System.Linq;
using System.IO;

namespace day3part1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input;
            input = File.ReadLines("Input.txt").ToArray();
            string gammaCal = "";
            string epsilonCal = "";
            int gammaResult = 0;
            int epsilonResult = 0;

            for (int i = 0; i < input[0].Length; i++)
            {
                int gammaZero = 0;
                int gammaOne = 0;

                for (int i1 = 0; i1 < input.Length; i1++)
                {
                    if (input[i1][i] == '0')
                    {
                        gammaZero++;
                    }
                    else
                    {
                        gammaOne++;
                    }
                }
                
                if (gammaZero < gammaOne)
                {
                    gammaCal += "1";
                    epsilonCal += "0";
                }
                else
                {
                    gammaCal += "0";
                    epsilonCal += "1";
                }
            }

            gammaResult = Convert.ToInt32(gammaCal, 2);
            epsilonResult = Convert.ToInt32(epsilonCal, 2);
            Console.WriteLine(gammaResult * epsilonResult);
            Console.Read();
        }
    }
}
