using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstRunner = int.Parse(Console.ReadLine());
            var secondRunner = int.Parse(Console.ReadLine());
            var thirdRunner = int.Parse(Console.ReadLine());
            var seconds = firstRunner + secondRunner + thirdRunner;
            var minutes = 0;
            if (seconds >= 60)
            {
                    minutes += 1;
                    seconds -= 60;
            }

            if (seconds >= 60)
            {
                minutes += 1;
                seconds -= 60;
            }
            if (seconds < 10)
            {
                Console.WriteLine(minutes + ":0" + seconds);
            }
            else
            {
                Console.WriteLine(minutes + ":" + seconds);
            }
            
        }
    }
}
