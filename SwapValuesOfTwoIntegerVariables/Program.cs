namespace SwapValuesOfTwoIntegerVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}