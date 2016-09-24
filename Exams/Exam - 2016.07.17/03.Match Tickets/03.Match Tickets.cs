using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string VIPorNormal = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            var price = 249.99;
            if (VIPorNormal == "VIP") price = 499.99;
            if (n <= 4) budget = budget * 0.25;
            else if (n >= 5 && n <= 9) budget = budget * 0.40;
            else if (n >= 10 && n <= 24) budget = budget * 0.50;
            else if (n >= 25 && n <= 49) budget = budget * 0.60;
            else budget = budget * 0.75;
            var totalMoneyNeeded = price * n;
            if (totalMoneyNeeded > budget)
            {
                var moneyNeeded = totalMoneyNeeded - budget;
                Console.WriteLine("Not enough money! You need {0:f2} leva.",moneyNeeded);
            }
            else
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.",budget - totalMoneyNeeded);
            }

        }
    }
}
