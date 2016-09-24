using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
           if (type == "banana" || type == "apple" || type == "kiwi" || type == "cherry" || type == "lemon" || type == "grapes")
            {
                Console.WriteLine("fruit");
            }
           else if (type == "tomato" || type == "cucumber" || type == "pepper" || type == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
