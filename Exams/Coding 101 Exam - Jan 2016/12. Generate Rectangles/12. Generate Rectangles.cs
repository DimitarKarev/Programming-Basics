using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Generate_Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            bool no = true;
            for (int left = - n; left <= n; left++)
            {
                for (int top = -n ; top <= n; top++)
                {
                    for (int right = left + 1; right <= n; right++)
                    {
                        for (int bottom = top + 1; bottom <= n; bottom++)
                        {
                            var wight = right - left;
                            var height = bottom - top;
                            var area = wight * height;
                            if (area >= m)
                            {
                            Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}",left ,top , right , bottom , area );
                                no = false;
                            }
                            
                        }
                    }
                }
            }
            if (no) Console.WriteLine("No");
        }
    }
}
