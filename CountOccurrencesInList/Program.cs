namespace CountOccurrencesInList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 2, 4, 2, 5 };
            int targetValue = 2;
            int count = CountOccurrences(list, targetValue);
            Console.WriteLine($"Броят на елементите със стойност {targetValue} е: {count}");
        }
        static int CountOccurrences(List<int> list, int targetValue)
        {
            int count = 0;
            foreach (int element in list)
            {
                if (element == targetValue)
                {
                    count++;
                }
            }
            return count;
        }
    }
}