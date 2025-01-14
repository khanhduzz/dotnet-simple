class Program
{
    public static void Main(string[] args)
    {
        string? input1, input2;
        string? operation;
        double num1, num2, result = 0;

        Console.WriteLine("Simple Calculator...");
        Console.WriteLine("Press Ctrl + Z, enter to exit...");
        Console.WriteLine();

        do
        {
            try
            {
                Console.Write("Enter first number: ");
                input1 = Console.ReadLine();
                if (input1 == null) break;
                num1 = double.Parse(input1);

                Console.Write("Enter operator (+, -, *, /): ");
                operation = Console.ReadLine();
                if (operation == null) break;

                Console.Write("Enter second number: ");
                input2 = Console.ReadLine();
                if (input2 == null) break;
                num2 = double.Parse(input2);

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            Console.WriteLine();
                            continue;
                        }
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Error: Invalid operator.");
                        Console.WriteLine();
                        continue;
                }


                Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
                Console.WriteLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid number format. Please enter numeric values.");
                Console.WriteLine();
            }

        } while (true);
    }
}