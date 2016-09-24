using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_0._._._100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var tens = n / 10;
            var ones = n % 10;

            if (n < 0 || n <= 100)
            {                
                if (n >= 10 || n < 20)
                {
                       if (n == 10) Console.WriteLine("ten");
                  else if (n == 11) Console.WriteLine("eleven");
                  else if (n == 12) Console.WriteLine("twelve");
                  else if (n == 13) Console.WriteLine("thirteen");
                  else if (n == 14) Console.WriteLine("fourteen");
                  else if (n == 15) Console.WriteLine("fifteen");
                  else if (n == 16) Console.WriteLine("sixteen");
                  else if (n == 17) Console.WriteLine("seventeen");
                  else if (n == 18) Console.WriteLine("eighteen");
                  else if (n == 19) Console.WriteLine("nineteen");
                }
                if (n < 100 || n >= 20)
                {
                      if (tens == 2) Console.Write("twenty");
                 else if (tens == 3) Console.Write("thirty");
                 else if (tens == 4) Console.Write("fourty");
                 else if (tens == 5) Console.Write("fifty");
                 else if (tens == 6) Console.Write("sixty");
                 else if (tens == 7) Console.Write("seventy");
                 else if (tens == 8) Console.Write("eighty");
                 else if (tens == 9) Console.Write("ninety");
                }
                if (n < 100 && n > 20 && n != 30 && n != 40 && n != 50 && n != 60 && n != 70 && n != 80 && n != 90) Console.Write(" ");
                if (n >=20 || n <= 9)
                {
                      if (ones == 1) Console.WriteLine("one");
                 else if (ones == 2) Console.WriteLine("two");
                 else if (ones == 3) Console.WriteLine("three");
                 else if (ones == 4) Console.WriteLine("four");
                 else if (ones == 5) Console.WriteLine("five");
                 else if (ones == 6) Console.WriteLine("six");
                 else if (ones == 7) Console.WriteLine("seven");
                 else if (ones == 8) Console.WriteLine("eight");
                 else if (ones == 9) Console.WriteLine("nine");
                }
                if (n == 100) Console.WriteLine("one hundred");
                if (n == 0) Console.WriteLine("zero");
            }
            if (n > 100 || n < 0) Console.WriteLine("Invalid Number");
        }
    }
}
