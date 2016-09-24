using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = 1;
            var spaces = n - 1;
            for (int row = 0; row < n; row++)
            {
                for (int i = 0; i < spaces; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int i = 0; i < stars - 1; i++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                stars++;
                spaces--;
            }
            spaces = 1;
            stars = n - 2;
            for (int row = 1; row < n; row++)
            {
                for (int i = 0; i < spaces; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int i = 0; i < stars; i++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                stars--;
                spaces++;
            }
        }
    }
}
