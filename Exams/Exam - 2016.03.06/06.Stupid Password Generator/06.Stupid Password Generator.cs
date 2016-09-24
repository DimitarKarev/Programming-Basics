using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            for (int n1 = 1; n1 <= n; n1++)
            {
                for (int n2 = 1; n2 <= n; n2++)
                {
                    for (char n3 = 'a'; n3 < 'a' + l ; n3++)
                    {
                        for (char n4 = 'a'; n4 < 'a' + l; n4++)
                        {
                            for (int n5 = 1; n5 <= n; n5++)
                            {
                                if ( n5 > n1 && n5 > n2)
                                Console.Write($"{n1}{n2}{n3}{n4}{n5} ");
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
