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

            for (int i1 = 0; i1 < input.Length; i1++)
            {
                inArray[i1].input = input[i1];
                inArray[i1].oActive = true;
                inArray[i1].o2Active = true;
            }

            string[] oxcal = new string[inArray[0].input.Length];
            string[] o2cal = new string[inArray[0].input.Length];
            int oxresult = 0;
            int oxDecResult = 0;
            int o2result = 0;
            int o2DecResult = 0;
            int finalResult = 0;
            int i = 0;

            #region Oxygen Calculation
            while (i < inArray[0].input.Length)
            {
                int currentlyActive = 0;
                int one = 0;
                int zero = 0;


                if (i != 0)
                {
                    for (int i1 = 0; i1 < inArray.Length; i1++)
                    {
                        if (inArray[i1].input[i-1] == oxcal[i - 1][0])
                        {
                            currentlyActive++;
                        }
                        else
                        {
                            inArray[i1].oActive = false;
                        }
                    }
                }


                if (currentlyActive == 1)
                {
                    for (int i1 = 0; i1 < inArray.Length; i1++)
                    {
                        if (inArray[i1].oActive)
                        {
                            oxresult = i1;
                            i = inArray[0].input.Length;
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


                if (one >= zero)
                {
                    oxcal[i] = "1";
                }
                else
                {
                    oxcal[i] = "0";
                }
                i++; 
            }
            #endregion

            #region O2Scrubber
            while (i < inArray[0].input.Length)
            {
                int currentlyActive = 0;
                int one = 0;
                int zero = 0;


                if (i != 0)
                {
                    for (int i1 = 0; i1 < inArray.Length; i1++)
                    {
                        if (inArray[i1].input[i - 1] == o2cal[i - 1][0])
                        {
                            currentlyActive++;
                        }
                        else
                        {
                            inArray[i1].o2Active = false;
                        }
                    }
                }


                if (currentlyActive == 1)
                {
                    for (int i1 = 0; i1 < inArray.Length; i1++)
                    {
                        if (inArray[i1].o2Active)
                        {
                            o2result = i1;
                            i = inArray[0].input.Length;
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


                if (zero >= one)
                {
                    o2cal[i] = "1";
                }
                else
                {
                    o2cal[i] = "0";
                }
                i++;
            }
            #endregion


            oxDecResult = Convert.ToInt32(inArray[oxresult].input, 2);
            o2DecResult = Convert.ToInt32(inArray[o2result].input, 2);

            finalResult =  oxDecResult * o2DecResult;
            Console.WriteLine(oxDecResult);
            Console.WriteLine(o2DecResult);
            Console.WriteLine(finalResult);
            Console.Read();
        }
    }
}
