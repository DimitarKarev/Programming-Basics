using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var workingDays = 365 - n;
            var playingHours = n * 127 + workingDays * 63;
            var difference = playingHours - 30000;
            var H = Math.Abs(difference / 60);
            var M = Math.Abs(difference % 60);
            if (difference <= 0)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", H , M);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play",H , M);
            }
        }
    }
}
