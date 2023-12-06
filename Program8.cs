using System;

class Program8
{
    static void Main()
    {
        try
        {
            TryRethrowException();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception caught in the Main method:");
            Console.WriteLine(ex.Message);

        }
    }

    static void TryRethrowException()
    {
        try
        {

            PerformDivision(10, 0);
        }
        catch (Exception originalException)
        {
            Console.WriteLine("Exception caught in the TryRethrowException method:");
            Console.WriteLine(originalException.Message);

            throw;
        }
    }

    static int PerformDivision(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }

        return numerator / denominator;
    }
}
