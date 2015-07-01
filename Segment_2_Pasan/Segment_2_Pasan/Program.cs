using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segment_2_Pasan
{
    class Program
    {
        static void Main(string[] args)
        {
            var retry = true;
            while (retry)
            {
                 retry = false;
                 Console.WriteLine("Please Gess the answer");
                 int ans = Int32.Parse(Console.ReadLine());
                 if (ans > 100 || ans < 1)
                 {
                     Console.WriteLine("Input was not between 1-100");
                     retry = true;
                 }

                 else if (ans != 42)
                 {
                     Console.WriteLine("Incorrect");
                     retry = true;
                 }

                 else if (ans == 42)
                 {
                     Console.WriteLine("Correct");
                     retry = false;
                 }
            }

            Console.ReadLine();
        }
    }
}
