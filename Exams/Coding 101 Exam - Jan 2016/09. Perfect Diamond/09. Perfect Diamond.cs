﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Perfect_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 1; row <=n; row++)
            {
                Console.Write(new string(' ', n - row));
                Console.Write('*');
                for (int col = 1 ; col < row; col++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
            for (int row = n - 1; row > 0; row--)
            {
                Console.Write(new string(' ', n - row));
                Console.Write('*');
                for (int col = 1; col < row; col++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
        }
    } 
}
