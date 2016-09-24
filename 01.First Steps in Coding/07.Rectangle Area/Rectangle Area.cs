using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете Страната а = ");
            var a = int.Parse(Console.ReadLine());
            Console.Write("Въведете Страната b = ");
            var b = int.Parse(Console.ReadLine());
            Console.Write("Лицето е: ");
            Console.WriteLine(a * b);
        }
    }
}
