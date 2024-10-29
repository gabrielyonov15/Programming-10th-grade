namespace FindingTheMajorityElementInAnArrayUsingAStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 2, 2, 3, 2, 1, 3, 2, 2, 2, 1 };
            Stack<int> stack = new Stack<int>();
            foreach (int number in numbers)
            {
                if (stack.Count > 0 && stack.Peek() != number)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(number);
                }
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("Няма мажорант в масива.");
                return;
            }
            int candidate = stack.Pop();
            int count = numbers.Count(x => x == candidate);
            if (count > numbers.Length / 2)
            {
                Console.WriteLine("Мажорантът на масива е: " + candidate);
            }
            else
            {
                Console.WriteLine("Няма мажорант в масива.");
            }
        }
    }
}