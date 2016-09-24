using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var longest = 0;
            var currentLongest = 0;
            var oldNum = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num > oldNum) 
                {
                    currentLongest++;
                    if (currentLongest > longest) longest = currentLongest;
                    
                }
                else 
                {
                    currentLongest = 1;
                }
                oldNum = num;
            }
            Console.WriteLine(longest);
        }
    }
}
