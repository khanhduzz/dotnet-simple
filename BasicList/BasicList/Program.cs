public class BasicList
{
    public static void Main(string[] args)
    {
        Console.WriteLine("List: ..............");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        Console.WriteLine("The list from 1 to 5: ");
        printList(numbers);

        numbers.Remove(3);
        Console.WriteLine("The list after removed: ");
        printList(numbers);
        Console.WriteLine("---------------------------------------------------------------");

        Console.WriteLine("Linked List: ..............");
        LinkedList<int> linkedList = new LinkedList<int>();
        for (int i = 1; i <= 5; i++)
        {
            linkedList.AddLast(i);
        }

        foreach (int i in linkedList)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("---------------------------------------------------------------");

        Console.WriteLine("Sorted List: ..............");
        SortedList<int, string> people = new SortedList<int, string>();
        people.Add(1, "David");
        people.Add(2, "Carter");
        
        foreach (KeyValuePair<int, string> pair in people)
        {
            Console.WriteLine(pair.Key + " " + pair.Value);
        }
        Console.WriteLine("---------------------------------------------------------------");

        Console.WriteLine("Queue: ..............");
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);

        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
        Console.WriteLine("---------------------------------------------------------------");

        Console.WriteLine("Stack: ..............");
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);

        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
        Console.WriteLine("---------------------------------------------------------------");

        Console.WriteLine("HashSet: ..............");
        HashSet<int> set = new HashSet<int>();
        set.Add(1);
        set.Add(2);

        Console.WriteLine("Hashset count: " + set.Count);
        Console.WriteLine("Hashset cabacity: " + set.Capacity);
        foreach (int i in set)
        {
            Console.WriteLine(i);
        }

    }

    public static void printList(List<int> list)
    {
        foreach (int i in list)
        {
            Console.WriteLine(i);
        }
    }
}