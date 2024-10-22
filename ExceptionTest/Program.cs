using System;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number:");
            string istr = Console.ReadLine();
            try
            {
                int i = Convert.ToInt32(istr);
                Console.WriteLine($"Number inserted: {i}");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Thank you for using this program");
            }
        }
    }
}
