﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer")
                    Console.WriteLine("Camp - {0:f2}",budget * 30 / 100);
                else 
                    Console.WriteLine("Hotel - {0:f2}", budget * 70 / 100);
            }
            else if (budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                    Console.WriteLine("Camp - {0:f2}", budget * 40 / 100);
                else
                    Console.WriteLine("Hotel - {0:f2}", budget * 80 / 100);
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", budget * 90 / 100);
            }
        }
    }
}
