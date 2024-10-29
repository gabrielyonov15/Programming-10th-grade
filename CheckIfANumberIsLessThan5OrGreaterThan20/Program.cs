namespace CheckIfANumberIsLessThan5OrGreaterThan20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 5 || number > 20)
            {
                Console.WriteLine("The number meets the conditions.");
            }
            else
            {
                Console.WriteLine("The number does not meet the conditions.");
            }
        }
    }
}