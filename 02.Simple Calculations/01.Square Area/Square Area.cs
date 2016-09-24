using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете Страна а = ");
           var a = int.Parse(Console.ReadLine());
            Console.Write("Лицето е: ");
            Console.WriteLine(a * a);
        }
    }
}
