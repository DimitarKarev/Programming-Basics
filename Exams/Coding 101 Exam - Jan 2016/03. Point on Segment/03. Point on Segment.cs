using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Point_on_Segment
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());
            var left = Math.Min(first, second);
            var right = Math.Max(first, second);
            var leftDistance = Math.Abs(left - point);
            var rightDistance = Math.Abs(right - point);
            var shortestDistance = Math.Min(rightDistance, leftDistance);
            if (point >= left && point <= right) Console.WriteLine("in");
            else Console.WriteLine("out");
            Console.WriteLine(shortestDistance);
        }
    }
}
