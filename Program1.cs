using System;

class lab_ass5_1
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        int indexToAccess = 7;

        try
        {
            int value = numbers[indexToAccess];
            Console.WriteLine($"Value at index {indexToAccess}: {value}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Index is out of range. Please access a valid index within the array bounds.");

        }
    }
}
