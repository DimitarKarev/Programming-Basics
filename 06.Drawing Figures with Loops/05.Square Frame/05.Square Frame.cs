using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n == 1) Console.WriteLine("+");
            else
            {
                for (int row = 0; row < n; row++)
                {
                    if (row == 0 || row == n - 1) Console.Write("+");
                    else Console.Write('|');
                    for (int col = 0; col < n - 2; col++)
                    {
                        Console.Write(" -");
                    }
                    if (row == 0 || row == n - 1) Console.Write(" +");
                    else Console.Write(" |");
                    Console.WriteLine();
                }
            }
            
        }
    }
}
