using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n; row++)
            {
                if (row == 0 || row == n - 1)
                {
                    Console.Write(new string('*', n * 2));
                    Console.Write(new string(' ', n));
                    Console.Write(new string('*', n * 2));
                }
                else
                {
                    Console.Write("*");
                    Console.Write(new string('/', (n * 2) - 2));
                    Console.Write("*");
                    if (row == (n - 1) / 2) Console.Write(new string('|', n)); 
                    else Console.Write(new string(' ', n));
                    Console.Write("*");
                    Console.Write(new string('/', (n * 2) - 2));
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
