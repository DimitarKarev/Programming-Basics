using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col <=n ; col++)
                {
                    Console.Write(col + " ");
                }
                for (int col2 = n - 1; col2 > n - row; col2--)
                {
                    Console.Write(col2 + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
