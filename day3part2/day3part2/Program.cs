using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace day3part2
{
    class Program
    {

        struct inputArray
        {
            public bool active;
            public string input;
        }

        static void Main(string[] args)
        {
            string[] input;
            input = File.ReadLines("Input.txt").ToArray();
            inputArray[] inArray = new inputArray[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                inArray[i].input = input[i];
            }

            string oxcal = " ";
            string o2cal = " ";
            int oxresult = 0;
            int o2result = 0;
            int finalResult = 0;

            for (int i = 0; i < input[0].Length; i++)
            {
                int one = 0;
                int zero = 0;

                for (int i1 = 0; i1 < inArray.Length; i1++)
                {
                    for (int i2 = 0; i2 < inArray.Length; i2++)
                    {
                        if (inArray[i1].input[] == oxcal)
                        {

                        }
                    }
                }

                for (int i1 = 0; i1 < input.Length; i1++)
                {
                    

                    if (input[i1][i] == '0')
                    {
                        zero++;
                    }
                    else
                    {
                        one++;
                    }
                }
                
                if (zero > one)
                {
                    oxcal += "0";
                    o2cal += "1";
                }
                else
                {
                    oxcal += "1";
                    o2cal += "0";
                }
            }

            oxresult = Convert.ToInt32(oxcal, 2);
            o2result = Convert.ToInt32(o2cal, 2);
            finalResult = oxresult * o2result;
            Console.WriteLine(finalResult);
            Console.Read();
        }
    }
}
