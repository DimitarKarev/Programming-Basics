using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = 1;
            if (n % 2 == 0) stars = 2;
            var dashes = (n - stars) / 2;
            var midDashes = -1;
            if (n % 2 == 0) midDashes = 0;
            
            for (int row = 0; row < (n + 1) / 2; row++)
            {
               Console.Write(new string('-', dashes));
               Console.Write("*");
               if (midDashes >= 0)
               {
                   Console.Write(new string('-', midDashes));
                   Console.Write("*");
               }
               Console.Write(new string('-', dashes));
               dashes -= 1;
               midDashes += 2;
                 
                Console.WriteLine();
            }
            dashes = 1;
            midDashes = n - 4;
           for (int row = 1 ; row < (n + 1) / 2; row++)
           {
              Console.Write(new string('-', dashes));
              Console.Write("*");
              if (midDashes >= 0)
              {
                  Console.Write(new string('-', midDashes));
                  Console.Write("*");
              }
              Console.Write(new string('-', dashes));
              dashes += 1;
              midDashes -= 2;
              Console.WriteLine();
           }       
        }
    }
}
