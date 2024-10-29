namespace PrintPositiveEvenNumbersLessThanN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 20; 
            for (int i = 2; i < N; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}