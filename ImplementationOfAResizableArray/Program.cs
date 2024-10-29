using System;

public class ArrayList<T>
{
    private T[] items;
    private int count;

    public ArrayList()
    {
        items = new T[2];
        count = 0;
    }
    public int Count
    {
        get { return count; }
    }
    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            return items[index];
        }
        set
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            items[index] = value;
        }
    }
    public void Add(T item)
    {
        if (count == items.Length)
        {
            Resize();
        }
        items[count] = item;
        count++;
    }
    public T RemoveAt(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new IndexOutOfRangeException("Index out of range");
        }
        T removedItem = items[index];
        Shift(index);
        count--;
        return removedItem;
    }
    private void Resize()
    {
        T[] newArray = new T[items.Length * 2];
        Array.Copy(items, newArray, items.Length);
        items = newArray;
    }
    private void Shift(int index)
    {
        for (int i = index; i < count - 1; i++)
        {
            items[i] = items[i + 1];
        }
        items[count - 1] = default(T); 
    }
}
class Program
{
    static void Main()
    {
        ArrayList<int> list = new ArrayList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        Console.WriteLine("Count after adding elements: " + list.Count); 
        Console.WriteLine("Element at index 1: " + list[1]);
        int removedElement = list.RemoveAt(1);
        Console.WriteLine("Removed element: " + removedElement); 
        Console.WriteLine("Count after removal: " + list.Count); 
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine("Element at index " + i + ": " + list[i]);
        }
    }
}