public class ModifyString
{
    public static void Main(string[] args)
    {
        string? input;
        Console.WriteLine("Reverse and Uppercase");
        Console.WriteLine("Press Ctrl + Z then Enter to exit\n");
        Console.Write("Enter a string: ");

        do
        {
            try
            {
                input = Console.ReadLine();

                if (input == null)
                {
                    break;
                }

                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new Exception("Invalid string input. Please enter a valid string.");
                }

                string result = new string(input.Reverse().ToArray()).ToUpper();
                Console.WriteLine("Result: " + result + "\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try again.\n");
            }

            Console.Write("Enter a string: ");
        } while (true);

        Console.WriteLine("Goodbye!");
    }
}
