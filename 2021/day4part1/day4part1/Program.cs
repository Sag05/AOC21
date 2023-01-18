using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace day4part1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            input = File.ReadLines("input.txt").ToArray();
            string[] numbers = input[0].Split(',');
            int numberOfBoards = (input.Length - 1) / 6;
            string[,,] boards = new string[numberOfBoards, 5, 5];


            for (int i = 0; i < numberOfBoards; i++)
            {
                for (int y = 0; y < 5; y++)
                {
                    string[] ySplit = 

                    for (int x = 0; x < 5; x++)
                    {
                        boards[i,y,x] = 
                    }
                }
            }



        }
    }
}
