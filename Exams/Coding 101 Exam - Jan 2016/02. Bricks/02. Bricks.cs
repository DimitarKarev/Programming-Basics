using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var bricksPerCourse = w * m ;
            var courses = Math.Ceiling(x / bricksPerCourse);
            Console.WriteLine(courses);
        }
    }
}
