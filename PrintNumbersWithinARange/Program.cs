namespace PrintNumbersWithinARange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10; 
            int b = 20; 
            for (int i = a + 1; i < b; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}