using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n + 1 ; row++)
            {
                for (int col = 0; col < n - row ; col++)
                {
                    Console.Write(" ");
                }
                for (int col = 0; col < row; col++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");
                for (int col = 0; col < row; col++)
                {
                    Console.Write("*");
                }
                for (int col = 0; col < n - row; col++)
                {
                    Console.Write(" ");
                }
               
                Console.WriteLine();
            }
        }
    }
}
