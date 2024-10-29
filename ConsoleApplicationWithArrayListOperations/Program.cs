using System.Collections;

namespace ConsoleApplicationWithArrayListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList { -3, 5, 1, 9, -12, 4, 6, -2, 0 };
            ReplaceNegativeWithZero(numbers);
            PrintArrayList(numbers);
            int positiveSum = CalculatePositiveSum(numbers);
            Console.WriteLine("Sum of positive numbers: " + positiveSum);
            FindMaxMinDifference(numbers);
        }
        static void ReplaceNegativeWithZero(ArrayList numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if ((int)numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
        }
        static void PrintArrayList(ArrayList numbers)
        {
            Console.WriteLine("ArrayList after replacing negatives: " + string.Join(", ", numbers.ToArray()));
        }
        static int CalculatePositiveSum(ArrayList numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    sum += number;
                }
            }
            return sum;
        }
        static void FindMaxMinDifference(ArrayList numbers)
        {
            int maxValue = int.MinValue;
            int minValue = int.MaxValue;
            foreach (int number in numbers)
            {
                if (number > maxValue)
                {
                    maxValue = number;
                }
                if (number < minValue)
                {
                    minValue = number;
                }
            }
            int difference = maxValue - minValue;
            Console.WriteLine($"max_value = {maxValue}, min_value = {minValue}, difference = {difference}");
        }
    }
}