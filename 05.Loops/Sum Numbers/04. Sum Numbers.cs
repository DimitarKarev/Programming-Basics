using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter n =  ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter {0} numbers", n);
            var sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("num {0} = ",i);
                var num = int.Parse(Console.ReadLine());
                sum += num;
                
            }
            Console.WriteLine("The Sum is: " + sum);
        }
    }
}
