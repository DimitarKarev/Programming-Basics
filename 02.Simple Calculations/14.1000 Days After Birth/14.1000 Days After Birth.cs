using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
           string birthDate = Console.ReadLine();
           string format = "dd-MM-yyyy";
           DateTime date = DateTime.ParseExact(birthDate, format, null );
           date = date.AddDays(999);
           Console.WriteLine("{0}", date.ToString(format));
        }
    }
}
