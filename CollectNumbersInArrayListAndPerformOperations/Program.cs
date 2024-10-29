using System.Collections;

namespace CollectNumbersInArrayListAndPerformOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList();
            int input;
            Console.WriteLine("Enter numbers (0 to stop):");
            while (true)
            {
                input = int.Parse(Console.ReadLine());
                if (input == 0)
                {
                    break;
                }
                numbers.Add(input);
            }
            if (numbers.Count > 0)
            {
                int max = (int)numbers[0];
                int min = (int)numbers[0];
                foreach (int number in numbers)
                {
                    if (number > max)
                    {
                        max = number;
                    }
                    if (number < min)
                    {
                        min = number;
                    }
                }
                Console.WriteLine("The largest number is: " + max);
                Console.WriteLine("The smallest number is: " + min);
            }
            else
            {
                Console.WriteLine("No numbers were entered.");
            }

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine("The sum of all entered numbers is: " + sum);
        }
    }
}