using System;


class CustomException : Exception
{
    public CustomException(string message) : base(message)
    {

    }
}

class lab_ass5_4
{
    static void Main()
    {
        try
        {
            int value = 100;

            if (value == 100)
            {

                throw new CustomException("Custom Exception: Value is 100.");
            }
        }
        catch (CustomException ex)
        {
            Console.WriteLine("Custom Exception caught:");
            Console.WriteLine(ex.Message);

        }
    }
}
