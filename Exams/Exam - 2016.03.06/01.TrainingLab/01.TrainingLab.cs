using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var rows = Math.Floor(w / 1.2);
            var seatsPerRow = Math.Floor((h - 1) / 0.7);
            var seats = (rows * seatsPerRow) - 3;
            Console.WriteLine(seats);
        }
    }
}
