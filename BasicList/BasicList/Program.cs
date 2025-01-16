public class BasicList
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        Console.WriteLine("The list from 1 to 5: ");

        printList(numbers);

        numbers.Remove(3);

        Console.WriteLine("The list after removed: ");
        printList(numbers);
    }

    public static void printList(List<int> list)
    {
        foreach (int i in list)
        {
            Console.WriteLine(i);
        }
    }
}