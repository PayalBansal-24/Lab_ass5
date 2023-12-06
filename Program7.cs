using System;

class Program7
{
    static void Main()
    {
        bool validInput = false;

        while (!validInput)
        {
            try
            {
                Console.Write("Enter the numerator: ");
                int numerator = int.Parse(Console.ReadLine());

                Console.Write("Enter the denominator: ");
                int denominator = int.Parse(Console.ReadLine());

                if (denominator == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero. Please enter a non-zero denominator.");
                }

                int result = DivideNumbers(numerator, denominator);
                Console.WriteLine($"Result of division: {result}");

                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }

    static int DivideNumbers(int numerator, int denominator)
    {
        return numerator / denominator;
    }
}
