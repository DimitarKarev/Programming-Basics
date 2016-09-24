using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            var V = int.Parse(Console.ReadLine());
            var P1 = int.Parse(Console.ReadLine());
            var P2 = int.Parse(Console.ReadLine());
            var H = double.Parse(Console.ReadLine());
            var pipe1 = H * P1;
            var pipe2 = H * P2;
            var total = pipe1 + pipe2;
            if (total <= V)
            {
                var percentFull = Math.Floor((total / V) * 100);
                var pipe1Percent = Math.Floor((pipe1 / total) * 100);
                var pipe2Percent = Math.Floor((pipe2 / total) * 100);
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", percentFull, pipe1Percent, pipe2Percent);
            }
            else
            {
                var overflow = total - V;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",H ,overflow);
            }
        }
    }
}
