using System;

public class Class1
{
    public Class1()
    {
    }
}
class Program3
{
    static void Main()
    {
        string userInput = "ABC";

        try
        {
            int parsedInt = int.Parse(userInput);
            Console.WriteLine($"Parsed integer: {parsedInt}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid input format. Please enter a valid integer.");

        }
    }
}
