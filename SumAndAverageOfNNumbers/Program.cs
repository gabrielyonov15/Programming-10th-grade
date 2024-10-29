namespace SumAndAverageOfNNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете броя на числата: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Въведете число {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int sum = numbers.Sum();
            double average = (double)sum / n;
            Console.WriteLine($"Сумата е: {sum}");
            Console.WriteLine($"Средното аритметично е: {average}");
        }
    }
}