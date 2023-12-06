using System;

namespace multipleException
{
    class multipleException
    {
        static void Main(string[] args)
        {

            try
            {
                int[] a = new int[5];
                Console.WriteLine(a[6]);

                string s = Console.ReadLine();
                int n = int.Parse(s);
                throw new InvalidOperationException("Invalid operation 										perform");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}