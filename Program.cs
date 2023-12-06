using System;

class lab_ass5_2
{
    static void Main()
    {
        try
        {
            int numerator = 10;
            int denominator = 0;

            int result = PerformDivision(numerator, denominator);
            Console.WriteLine($"Result of division: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Divide by zero error occurred. Please provide a non-zero denominator.");

        }
    }

    static int PerformDivision(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new DivideByZeroException();
        }

        return numerator / denominator;
    }
}
