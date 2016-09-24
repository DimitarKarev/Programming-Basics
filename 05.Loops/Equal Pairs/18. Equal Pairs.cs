using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var minSum = double.MaxValue;
            var maxSum = double.MinValue;
            double diff = 0;
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double firstNumber = double.Parse(Console.ReadLine());
                double secondNumber = double.Parse(Console.ReadLine());
                var currentSum = firstNumber + secondNumber;
                diff = Math.Abs(sum - currentSum);
                sum = currentSum;
                if (currentSum > maxSum) maxSum = currentSum;
                if (currentSum < minSum) minSum = currentSum;
            }
            if (maxSum == minSum) Console.WriteLine("Yes, value ={0}",maxSum);
            else Console.WriteLine("No, maxdiff ={0}",diff);
        }
    }
}
