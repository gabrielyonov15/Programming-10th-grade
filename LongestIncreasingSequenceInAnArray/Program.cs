namespace LongestIncreasingSequenceInAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете числа, разделени със запетая: ");
            int[] numbers = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int maxLength = 1;
            int currentLength = 1;
            int endIndex = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    currentLength++;
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        endIndex = i;
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }
            int startIndex = endIndex - maxLength + 1;
            int[] longestSequence = numbers.Skip(startIndex).Take(maxLength).ToArray();
            Console.WriteLine("Най-дългата нарастваща поредица е: " + string.Join(", ", longestSequence));
        }
    }
}