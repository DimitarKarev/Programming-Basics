using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            double apartment = 0.0;
            double studio = 0.0;
            var studioDiscount = 1.0;
            var apartmentDiscount = 1.0;
            if (n > 14) apartmentDiscount = 0.90;
            if (month == "May" || month == "October")
            {
                studio = 50;
                apartment = 65;
                if (n > 7 && n <= 14) studioDiscount = 0.95;
                else if (n > 14) studioDiscount = 0.70;
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.20;
                apartment = 68.70;
                if (n > 14) studioDiscount = 0.80;
            }
            else 
            {
                studio = 76;
                apartment = 77;
            }
            var apartmentCost = n * (apartment * apartmentDiscount);
            var studioCost = n * (studio * studioDiscount);
            Console.WriteLine("Apartment: {0:f2} lv.", apartmentCost);
            Console.WriteLine("Studio: {0:f2} lv.", studioCost);
        }
    }
}
