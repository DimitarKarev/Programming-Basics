using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете USD = ");
            var usd = double.Parse(Console.ReadLine());
            var bgn = usd * 1.79549;
            Console.Write("BGN = ");
            Console.Write(Math.Round(bgn, 2));
            Console.WriteLine(" BGN");
        }
    }
}
