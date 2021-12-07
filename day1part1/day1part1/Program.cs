using System;
using System.Linq;
using System.IO;

namespace day1part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int larger = 0;
            string[] input;
            input = File.ReadLines("Input.txt").ToArray();
            
            int[] numInput = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numInput[i] = int.Parse(input[i]);

            }

            for (int i = 0; i < input.Length -1; i++)
            {
                if (numInput[i] < numInput[i + 1])
                {
                    larger++;
                }
            }

            Console.WriteLine(larger);
            Console.Read();
        }
    }
}
