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
            public string input;
            public bool oActive;
            public bool o2Active;
        }

        static void Main(string[] args)
        {
            string[] input;
            input = File.ReadLines("Input.txt").ToArray();
            inputArray[] inArray = new inputArray[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                inArray[i].input = input[i];
                inArray[i].oActive = true;
                inArray[i].o2Active = true;
            }

            string[] oxcal = new string[inArray[0].input.Length];
            string[] o2cal = new string[inArray[0].input.Length];
            int oxresult = 0;
            int o2result = 0;
            int finalResult = 0;


            #region Oxygen Calculation
            for (int i = 0; i < input[0].Length; i++)
            {
                int currentlyActive = 0;
                int one = 0;
                int zero = 0;

                for (int i1 = 0; i1 < inArray.Length; i1++)
                {
                    for (int i2 = 0; i2 < oxcal.Length; i2++)
                    {
                        if (!string.IsNullOrEmpty(oxcal[i2]))
                        {
                            if (inArray[i1].input[i2] != oxcal[i2][1])
                            {
                                inArray[i2].oActive = false;
                            }
                            else
                            {
                                currentlyActive++;
                            }
                        }
                    }
                }

                if (currentlyActive == 1)
                {
                    for (int i1 = 0; i1 < inArray.Length; i1++)
                    {
                        if (inArray[i1].oActive)
                        {
                            oxresult = Convert.ToInt32(string.Join("", inArray[i1].input), 2);
                        }
                    }
                }

                for (int i1 = 0; i1 < inArray.Length; i1++)
                {
                    if (inArray[i1].input[i] == '0' && inArray[i1].oActive)
                    {
                        zero++;
                    }
                    else if (inArray[i1].oActive)
                    {
                        one++;
                    }
                }

                if (zero > one)
                {
                    oxcal[i] = "0";
                }
                else
                {
                    oxcal[i] = "1";
                }
            }
            #endregion


            #region O2 Scrubber Calculation
            for (int i = 0; i < input[0].Length; i++)
            {
                int currentlyActive = 0;
                int one = 0;
                int zero = 0;

                for (int i1 = 0; i1 < inArray.Length; i1++)
                {
                    for (int i2 = 0; i2 < o2cal.Length; i2++)
                    {
                        if (!string.IsNullOrEmpty(o2cal[i2]))
                        {
                            if (inArray[i1].input[i2] != o2cal[i2][1])
                            {
                                inArray[i2].o2Active = false;
                            }
                            else
                            {
                                currentlyActive++;
                            }
                        }
                    }
                }

                if (currentlyActive == 1)
                {
                    for (int i1 = 0; i1 < inArray.Length; i1++)
                    {
                        if (inArray[i1].o2Active)
                        {
                            o2result = Convert.ToInt32(string.Join("", inArray[i1].input), 2);
                        }
                    }
                }

                for (int i1 = 0; i1 < inArray.Length; i1++)
                {
                    if (inArray[i1].input[i] == '0' && inArray[i1].o2Active)
                    {
                        zero++;
                    }
                    else if (inArray[i1].o2Active)
                    {
                        one++;
                    }
                }

                if (one > zero)
                {
                    oxcal[i] = "0";
                }
                else
                {
                    oxcal[i] = "1";
                }
            }
            #endregion


            finalResult = oxresult * o2result;
            Console.WriteLine(finalResult);
            Console.Read();
        }
    }
}
