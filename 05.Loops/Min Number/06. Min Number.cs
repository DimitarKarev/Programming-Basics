using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (sum > num)
                {
                    sum = num;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
