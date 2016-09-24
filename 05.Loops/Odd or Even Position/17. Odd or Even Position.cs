using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_or_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double evenMin = int.MaxValue;
            double oddMin = int.MaxValue;
            double evenMax = int.MinValue;
            double oddMax = int.MinValue;
            double evenSum = 0;
            double oddSum = 0;
            
                for (double i = 0; i < n; i++)
                {
                    var num = double.Parse(Console.ReadLine());
                    if (i % 2 == 0)
                    {
                        oddSum += num;
                        if (num < oddMin) oddMin = num;
                        if (num > oddMax) oddMax = num;
                    }
                    else 
                    {
                        evenSum += num;
                        if (num < evenMin) evenMin = num;
                        if (num > evenMax) evenMax = num;
                    }
                }
                
               Console.WriteLine("OddSum ={0}", oddSum);
            if (oddMin == int.MaxValue) Console.WriteLine("OddMin =No");
            else Console.WriteLine("OddMin ={0}", oddMin);
            if (oddMax == int.MinValue) Console.WriteLine("OddMax =No");
            else Console.WriteLine("OddMax ={0}", oddMax);
               Console.WriteLine("EvenSum ={0}", evenSum);
            if (evenMin == int.MaxValue) Console.WriteLine("EvenMin =No");
            else Console.WriteLine("EvenMin ={0}", evenMin);
            if (evenMax == int.MinValue) Console.WriteLine("EvenMax =No");
            else Console.WriteLine("EvenMax ={0}", evenMax);
            }        
    }
}
