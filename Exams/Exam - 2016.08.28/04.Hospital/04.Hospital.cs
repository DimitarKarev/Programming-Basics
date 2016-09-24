using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var doctors = 7;
            var treatedPatiants = 0;
            var untreatedPatiants = 0;
            for (int i = 1; i <= n; i++)
            {
                var patiants = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && untreatedPatiants > treatedPatiants) doctors++;
                if (patiants > doctors)
                {
                    untreatedPatiants += (patiants - doctors);
                }
                if (patiants >= doctors) treatedPatiants += doctors;
                else treatedPatiants += patiants;
            }
            Console.WriteLine("Treated patients: {0}.", treatedPatiants);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatiants);
        }
    }
}
