using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i1 = 1; i1 < 10; i1++)
             for (int i2 = 1; i2 < 10; i2++)
              for (int i3 = 1; i3 < 10; i3++)
               for (int i4 = 1; i4 < 10; i4++)
               {
               if (n % i1 == 0 && n % i2 == 0 && n % i3 == 0 && n % i4 == 0)
                 Console.Write($"{i1}{i2}{i3}{i4} ");
               }
            Console.WriteLine();
        }
    }
}
