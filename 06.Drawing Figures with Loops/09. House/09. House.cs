using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = 0;
            if (n % 2 == 0) stars = 2;
            else stars = 1;
            var dashes = (n - stars) / 2;
           
            for (int row = 0; row < (n+1)/2; row++)
            {  
                    Console.Write(new string('-',dashes));
                    Console.Write(new string('*', stars));
                    Console.Write(new string('-', dashes));
                dashes--;
                stars +=2;
                Console.WriteLine();
            }
            for (int row = 0; row < n /2; row++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.Write("|");
                Console.WriteLine();
            }
        }
    }
}
