using System;

class Calculator
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("Enter two numbers:");

            Console.Write("Number 1: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Number 2: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose an operation (+, -, *, /):");
            char operation = char.Parse(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException("Division by zero is not allowed.");
                    }
                    result = num1 / num2;
                    break;
                default:
                    throw new InvalidOperationException("Invalid operation. Please enter '+', '-', '*', or '/'.");
            }

            Console.WriteLine($"Result: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Arithmetic operation caused an overflow. Please enter smaller numbers.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
