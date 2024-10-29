namespace CalculateAverageOfPositiveElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -3, 5, 7, -2, 10, -8 };
            double average = CalculatePositiveAverage(array);
            Console.WriteLine($"Средната стойност на положителните елементи е: {average}");
        }
        static double CalculatePositiveAverage(int[] array)
        {
            int sum = 0;
            int count = 0;
            foreach (int element in array)
            {
                if (element > 0)
                {
                    sum += element;
                    count++;
                }
            }
            if (count > 0)
            {
                return (double)sum / count;
            }
            else
            {
                return 0;
            }
        }
    }
}