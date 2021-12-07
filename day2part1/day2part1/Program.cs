using System;
using System.Linq;
using System.IO;

namespace day2part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int depth = 0;
            int forward = 0;
            string[] input;
            input = File.ReadLines("Input.txt").ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                string[] split = input[i].Split(' ');
                int num = int.Parse(split[1]);

                if (split[0] == "forward")
                {
                    forward += num;
                }

                else if (split[0] == "down")
                {
                    depth += num;
                }

                else if (split[0] == "up")
                {
                    depth -= num;
                }
            }

            Console.WriteLine(forward * depth);
            Console.Read();
        }
    }
}
