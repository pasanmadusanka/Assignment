using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segment_4_Pasan
{
    class Program
    {
        public List<string> Sort(List<string> theList, char theChar)
        {
            foreach (string chr in theList) // Loop through List with foreach.
            {
                if ((chr[0]) == theChar)
                {
                    Console.WriteLine(chr);
                }
            }
            return theList;
        }

        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("sam");
            list.Add("kamal");
            list.Add("anura");
            list.Add("kasun");
            list.Add("ajith");

            char foo = 'a';
            Program seg = new Program();
            seg.Sort(list, foo);

            Console.ReadLine();
        }
    }
}
