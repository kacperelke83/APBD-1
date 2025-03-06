using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD1
{
    class avg
    {
        static double CalculateAverage(int[] numbers)
        {
            return numbers.Average();
        }

        static void Main()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Średnia: " + CalculateAverage(values));
        }

    }
}
