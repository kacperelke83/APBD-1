

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
            Console.WriteLine("AVG change2 " + CalculateAverage(values));
            Console.WriteLine("change!");
        }

    }
}
