public class ListWithLINQ
{
    public static void Main(string[] args)
    {
        List<int> input = new List<int> { 1, 2, 3, 4, 5, 6 };

        Console.Write("The original list: ");
        foreach (int i in input) Console.Write(i + " ");

        var result = from i in input
                          where i % 2 == 0
                          orderby i descending
                          select i;

        Console.Write("\nFiltered and sorted list: ");
        foreach (int i in result) Console.Write(i + " ");
    }
}