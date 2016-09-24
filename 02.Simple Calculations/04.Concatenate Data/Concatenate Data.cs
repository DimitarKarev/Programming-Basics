using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter First Name: ");
            var firstName = Console.ReadLine();
            //Console.WriteLine("Enter Last Name: ");
            var lastName = Console.ReadLine();
            //Console.WriteLine("Enter Age: ");
            var age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Town: ");
            var town = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", firstName, lastName, age, town );
            
        }
    }
}
