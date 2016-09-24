using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1 ; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > sum)
                {
                    sum = num;
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
