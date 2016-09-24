using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Rectangle_with_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var rows = n;
            if (n % 2 == 0) rows--;
            Console.WriteLine(new string('%',2 *n));
            for (int row = 0; row < rows; row++)
            {
                Console.Write('%');
                Console.Write(new string(' ',n - 2));
                if (row  == rows / 2) Console.Write("**");
                else Console.Write("  ");
                Console.Write(new string(' ', n - 2));
                Console.Write('%');
                Console.WriteLine();
            }
            Console.WriteLine(new string('%', 2 * n));
        }
    }
}
