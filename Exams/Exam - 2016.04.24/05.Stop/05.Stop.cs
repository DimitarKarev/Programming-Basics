using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.Write(new string('.', n + 1));
            Console.Write(new string('_', 2 * n + 1));
            Console.WriteLine(new string('.', n + 1));
            for (int row = 0; row < n; row++)
            {
                Console.Write(new string('.', n - row));
                Console.Write("//");
                Console.Write(new string('_',(2 * n) - 1 + (2 * row)));
                Console.Write("\\\\");
                Console.Write(new string('.', n - row));
                Console.WriteLine();
            }
            Console.Write("//");
            Console.Write(new string('_', (4 * n - 5) / 2));
            Console.Write("STOP!");
            Console.Write(new string('_', (4 * n - 5) / 2));
            Console.WriteLine("\\\\");
            for (int row = n; row > 0; row--)
            {
                Console.Write(new string('.', n - row));
                Console.Write("\\\\");
                Console.Write(new string('_', (2 * n) - 1 + (2 * row)));
                Console.Write("//");
                Console.Write(new string('.', n - row));
                Console.WriteLine();
            }
        }
    }
}
