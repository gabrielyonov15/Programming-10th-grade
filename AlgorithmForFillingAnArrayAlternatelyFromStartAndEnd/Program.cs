namespace AlgorithmForFillingAnArrayAlternatelyFromStartAndEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int left = 0;
            int right = n - 1;
            int value = 1;
            while (left <= right)
            {
                array[left] = value;
                value++;
                if (left != right)
                {
                    array[right] = value;
                    value++;
                }
                left++;
                right--;
            }
            Console.WriteLine("Filled array:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}