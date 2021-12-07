using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace day2part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int depth = 0;
            int forward = 0;
            int aim = 0;
            string[] input;
            input = File.ReadLines("Input.txt").ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                string[] split = input[i].Split(' ');
                int num = int.Parse(split[1]);

                if (split[0] == "forward")
                {
                    forward += num;
                    depth += aim * num;
                }

                else if (split[0] == "down")
                {
                    aim += num;
                }

                else if (split[0] == "up")
                {
                    aim -= num;
                }
            }

            Console.WriteLine(forward * depth);
            Console.Read();
        }
    }
}
