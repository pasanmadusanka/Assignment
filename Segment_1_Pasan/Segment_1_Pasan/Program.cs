﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segment_1_Pasan
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("SupportTraining");
                }

                if (i % 3 == 0)
                {
                    Console.WriteLine("Support");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Training");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
