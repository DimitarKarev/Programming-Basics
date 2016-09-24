using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var biggestNumber = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > biggestNumber)
                {
                    biggestNumber = num;
                }
            }
            var sumMinusBiggestNumber = sum - biggestNumber;
            var diff = Math.Abs(biggestNumber - sumMinusBiggestNumber);
            if (sumMinusBiggestNumber == biggestNumber)
            {
                Console.WriteLine("Yes Sum = {0}",biggestNumber);
            }
            else
            {
                Console.WriteLine("No Diff = {0}",diff);
            }
        }
    }
}
