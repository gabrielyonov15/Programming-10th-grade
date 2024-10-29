using System.Collections;

namespace ArrayToArrayListConversionAndSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = { 5, 1, 9, -3, 4, 6, 0, -2, 3 };
            ArrayList numbersList = new ArrayList(numbersArray);
            numbersList.Sort();
            Console.WriteLine("Sorted ArrayList: " + string.Join(", ", numbersList.ToArray()));
        }
    }
}