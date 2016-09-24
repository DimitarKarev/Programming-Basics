using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = Double.Parse(Console.ReadLine());
            var w = Double.Parse(Console.ReadLine());
            h = h * 100;
            w = (w * 100) - 100;
            var rows = Math.Floor(h / 120);
            var seatsPerRow = Math.Floor(w / 70);
            var seats = (rows * seatsPerRow) - 3;
            Console.WriteLine(seats);
        }
    }
}
