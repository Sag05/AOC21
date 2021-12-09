using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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
            bool oxRunning = true;
            int oxRun = 0;
            int o2result = 0;
            int o2DecResult = 0;
            bool o2Running = true;
            int o2Run = 0;
            int finalResult = 0;
            

            #region Oxygen Calculation
            while (oxRunning)
            {
                int currentlyActive = 0;
                int one = 0;
                int zero = 0;

                //set number of active first run
                if (oxRun == 0)
                {
                    currentlyActive = inArray.Length;
                }


                //Check ammount of active
                if (oxRun != 0 && oxRun < inArray[0].input.Length)
                {
                    for (int i1 = 0; i1 < inArray.Length; i1++)
                    {
                        if (inArray[i1].input[oxRun - 1] == oxcal[oxRun - 1][0] && inArray[i1].oActive == true)
                        {
                            currentlyActive++;
                        }
                        else
                        {
                            inArray[i1].oActive = false;
                        }
                    }
                }

                //check if only one still active
                if (currentlyActive <= 2)
                {
                    if (currentlyActive == 2)
                    {
                        for (int i1 = 0; i1 < inArray.Length; i1++)
                        {
                            if (inArray[i1].input[oxRun] == '1' && inArray[i1].oActive)
                            {
                                Console.WriteLine("Correct");
                                oxresult = i1;
                                oxRunning = false;
                            }
                        }
                    }
                    else
                    {
                        for (int i1 = 0; i1 < inArray.Length; i1++)
                        {
                            if (inArray[i1].oActive)
                            {
                                Console.WriteLine("Correct");
                                oxresult = i1;
                                oxRunning = false;
                            }
                        }
                    }
                }


                //one/zero most common in bit
                if (oxRun < inArray[0].input.Length)
                {
                    for (int i1 = 0; i1 < inArray.Length; i1++)
                    {
                        if (inArray[i1].input[oxRun] == '0' && inArray[i1].oActive)
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
                        oxcal[oxRun] = "1";
                    }
                    else
                    {
                        oxcal[oxRun] = "0";
                    }
                }
                Console.WriteLine(currentlyActive);
                //Thread.Sleep(1000);
                oxRun++; 
            }
            #endregion

            #region O2Scrubber
            while (o2Running)
            {
                int currentlyActive = 0;
                int one = 0;
                int zero = 0;

                //set number of active first run
                if (o2Run == 0)
                {
                    currentlyActive = inArray.Length;
                }


                //Check ammount of active
                if (o2Run != 0 && o2Run < inArray[0].input.Length)
                {
                    Console.WriteLine("debug");
                    for (int i1 = 0; i1 < inArray.Length; i1++)
                    {
                        if (inArray[i1].input[o2Run - 1] == o2cal[o2Run - 1][0] && inArray[i1].o2Active == true)
                        {
                            currentlyActive++;
                        }
                        else
                        {
                            inArray[i1].o2Active = false;
                        }
                    }
                }

                //check if only one still active
                if (currentlyActive <= 2)
                {
                    if (currentlyActive == 2)
                    {
                        for (int i1 = 0; i1 < inArray.Length; i1++)
                        {
                            if (inArray[i1].input[o2Run] == '0' && inArray[i1].o2Active)
                            {
                                Console.WriteLine("Correct");
                                o2result = i1;
                                o2Running = false;
                            }
                        }
                    }
                    else
                    {
                        for (int i1 = 0; i1 < inArray.Length; i1++)
                        {
                            if (inArray[i1].o2Active)
                            {
                                Console.WriteLine("Correct");
                                o2result = i1;
                                o2Running = false;
                            }
                        }
                    }
                }


                //one/zero most common in bit
                if (o2Run < inArray[0].input.Length)
                {
                    for (int i1 = 0; i1 < inArray.Length; i1++)
                    {
                        if (inArray[i1].input[o2Run] == '0' && inArray[i1].o2Active)
                        {
                            zero++;
                        }
                        else if (inArray[i1].o2Active)
                        {
                            one++;
                        }
                    }

                    if (zero == one)
                    {
                        o2cal[o2Run] = "0";
                    }
                    if (zero > one)
                    {
                        o2cal[o2Run] = "1";
                    }
                    else
                    {
                        o2cal[o2Run] = "0";
                    }
                }
                Console.WriteLine(currentlyActive);
                //Thread.Sleep(1000);
                o2Run++;
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
