namespace PrintNumbersDivisibleByXWithInARange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10; 
            int b = 50;
            int x = 5;  
            for (int i = a + 1; i < b; i++)
            {
                if (i % x == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}