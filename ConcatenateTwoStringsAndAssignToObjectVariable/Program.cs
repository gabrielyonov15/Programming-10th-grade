namespace ConcatenateTwoStringsAndAssignToObjectVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";
            object result = str1 + " " + str2; 
            Console.WriteLine(result);
        }
    }
}