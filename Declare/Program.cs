using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int quantity = 1;
        double price = 12.25;
        string description = "Best quality...";
        bool available = true;
        
        Console.WriteLine("The quantity is: " + quantity);
        Console.WriteLine("The price is: " + price);
        Console.WriteLine("The description is: " + description);
        Console.WriteLine("Product is available: " + (available ? "Yes" : "No"));
    }
}