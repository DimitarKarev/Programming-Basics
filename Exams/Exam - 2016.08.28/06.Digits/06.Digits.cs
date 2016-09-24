using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var firstDigit = (n / 100) % 10;
            var secondDigit = (n / 10) % 10;
            var thirdDigit = n % 10;
            var rows = firstDigit + secondDigit;
            var cols = firstDigit + thirdDigit;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (n % 5 == 0) n -= firstDigit;
                    else if (n % 3 == 0) n -= secondDigit;
                    else n += thirdDigit;
                    Console.Write("{0} ", n);
                }
                Console.WriteLine();
            }
        }
    }
}
