using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var washingMashinePrice = double.Parse(Console.ReadLine());
            var toyPrice = int.Parse(Console.ReadLine());
            var totalMoney = 0;
            var moneyOnBirthday = 10;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    totalMoney += moneyOnBirthday;
                    moneyOnBirthday += 10;
                    totalMoney -= 1;
                }
                else totalMoney += toyPrice;
            }
            double moneyLeft = totalMoney - washingMashinePrice;
            if (moneyLeft < 0) Console.WriteLine("No! {0:f2}",Math.Abs(moneyLeft));
            else Console.WriteLine("Yes! {0:f2}",moneyLeft);
        }
    }
}
