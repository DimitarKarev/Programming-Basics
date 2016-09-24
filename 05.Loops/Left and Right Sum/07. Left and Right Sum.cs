using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var firstSum = 0;
            var secondSum = 0;
            for (int i = 0; i < n; i++)
            {
                var x = int.Parse(Console.ReadLine());
                firstSum += x;
            }
            for (int i = 0; i < n; i++)
            {
                var x = int.Parse(Console.ReadLine());
                secondSum += x;
            }
            var diff = Math.Abs(firstSum - secondSum);
            if (firstSum == secondSum)
            {
                Console.WriteLine("Yes, sum = {0}",firstSum);
            }
            else
            { 
                Console.WriteLine("No, diff = {0}", diff);
            }
        }
    }
}
