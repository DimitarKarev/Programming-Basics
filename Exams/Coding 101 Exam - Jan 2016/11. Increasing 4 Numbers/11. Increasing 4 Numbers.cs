﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Increasing_4_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            bool no = true;
            for (int n1 = a; n1 < b; n1++)
            {
                for (int n2 = n1 + 1; n2 < b; n2++)
                {
                    for (int n3 = n2 + 1; n3 < b; n3++)
                    {
                        for (int n4 = n3 + 1; n4 <= b; n4++)
                        {
                            Console.WriteLine($"{n1} {n2} {n3} {n4}");
                            no = false;
                        }
                    }
                }
            }
            if (no) Console.WriteLine("No");                      
        }
    }
}
