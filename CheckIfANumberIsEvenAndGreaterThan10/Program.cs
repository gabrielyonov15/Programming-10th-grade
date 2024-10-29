namespace CheckIfANumberIsEvenAndGreaterThan10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number > 10 && number % 2 == 0)
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