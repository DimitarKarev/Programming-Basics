using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Repairing_The_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double o = double.Parse(Console.ReadLine());
            var area = n * n;
            var areaWithTiles = area - (m * o);
            var tileArea = w * l;
            var tiles = areaWithTiles / tileArea;
            var time = tiles * 0.2;
            Console.WriteLine(tiles);
            Console.WriteLine(time);
            
        }
    }
}
