using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            char o = char.Parse(Console.ReadLine());
            double result = 0;
            if (n2 == 0 && (o == '/' || o == '%'))
            {
                Console.WriteLine("Cannot divide {0} by zero",n1);
                return;
            }
            if (o == '/')
            {
                 result = Math.Round(n1 * 1.00 / n2,2);
                Console.WriteLine("{0} / {1} = {2:f2}",n1 , n2 ,result);
            }
          else if (o == '%')
            {
                var reminder = n1 % n2;
                Console.WriteLine("{0} % {1} = {2}",n1 ,n2 ,reminder);
            }
            else
            {
                if (o == '+')
                {
                    result = n1 + n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine("{0} + {1} = {2} - even",n1 , n2 ,result);
                    }
                    else Console.WriteLine("{0} + {1} = {2} - odd", n1, n2, result);
                }
              else  if (o == '-')
                {
                    result = n1 - n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine("{0} - {1} = {2} - even", n1, n2, result);
                    }
                    else Console.WriteLine("{0} - {1} = {2} - odd", n1, n2, result);
                }
                else if (o == '*')
                {
                    result = n1 * n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine("{0} * {1} = {2} - even", n1, n2, result);
                    }
                    else Console.WriteLine("{0} * {1} = {2} - odd", n1, n2, result);
                }
            }
        }
    }
}
