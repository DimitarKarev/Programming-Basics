using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sums_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var smallestNumber = Math.Min(a, Math.Min(b, c));
            var biggestNumber = Math.Max(a, Math.Max(b, c));
            var midNumber = (a + b + c - smallestNumber - biggestNumber);
            if (smallestNumber + midNumber == biggestNumber)
            Console.WriteLine("{0} + {1} = {2}",smallestNumber ,midNumber , biggestNumber);
            else Console.WriteLine("No");
            
        }
    }
}
