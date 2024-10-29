namespace CreateADynamicArrayAndPerformOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> dynamicArray = new List<int>();
            int input;
            Console.WriteLine("Enter numbers (0 to stop):");
            while (true)
            {
                input = int.Parse(Console.ReadLine());
                if (input == 0)
                {
                    break;
                }
                dynamicArray.Add(input);
            }
            int sum = 0;
            foreach (var number in dynamicArray)
            {
                sum += number;
            }
            Console.WriteLine("Sum of all entered numbers: " + sum);
            dynamicArray.RemoveAll(n => n < 0);
            Console.WriteLine("Remaining numbers in the array:");
            foreach (var number in dynamicArray)
            {
                Console.WriteLine(number);
            }
        }
    }
}