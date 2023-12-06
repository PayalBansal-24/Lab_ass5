using System;

class multipletryblock
{
    static void Main(string[] args)
    {
        try
        {
            try
            {
                int a = 25;
                int b = 0;
                int result = a / b;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException i)
            {
                Console.WriteLine("Inner catch block: " + i.Message);
                throw;
            }
        }
        catch (Exception o)
        {
            Console.WriteLine("Outer catch block: " + o.Message);
        }
        Console.ReadLine();
    }
}
