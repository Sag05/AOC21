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
            int[] added = new int[numInput.Length - 2];

            for (int i = 0; i < input.Length; i++)
            {
                numInput[i] = int.Parse(input[i]);
            }

            for (int i = 0; i < added.Length; i++)
            {
                added[i] = numInput[i] + numInput[i + 1] + numInput[i + 2];
            }

            for (int i = 0; i < added.Length - 1; i++)
            {
                if (added[i] < added[i + 1])
                {
                    larger++;
                }
            }
            Console.WriteLine(larger);
            Console.Read();
        }
    }
}
