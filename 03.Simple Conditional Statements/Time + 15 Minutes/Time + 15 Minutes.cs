using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());
            min += 15;
            if (min >= 60)
            {
                min -= 60;
                hour += 1;
            }
            if (hour>=24)
            {
                hour -= 24;
            }
            if (min<10)
            {
                Console.WriteLine("{0}:0{1}", hour, min);
            }
            else
            {
                Console.WriteLine("{0}:{1}", hour, min);
            }
            
        }
    }
}
