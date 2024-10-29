namespace CopyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> originalList = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
            LinkedList<int> copiedList = CopyLinkedList(originalList);
            Console.WriteLine("Оригинален списък:");
            foreach (int item in originalList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nКопиран списък:");
            foreach (int item in copiedList)
            {
                Console.Write(item + " ");
            }
        }
        static LinkedList<int> CopyLinkedList(LinkedList<int> originalList)
        {
            LinkedList<int> newList = new LinkedList<int>();
            foreach (int item in originalList)
            {
                newList.AddLast(item);
            }
            return newList;
        }
    }
}