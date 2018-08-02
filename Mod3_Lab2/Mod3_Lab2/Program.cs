using System;

namespace Mod3_Lab2
{
    class Program
    {
        static void Main()
        {
            int first = 9;
            int second = 0;

            Console.Write("First number: ");
            first = Int32.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            second = Int32.Parse(Console.ReadLine());

            int result = Divide(first, second);
            Console.WriteLine($"The result of dividing {first} by {second} is {result}");

        }

        //// Method Divide() accepts two integer arguments and returns the result 
        //// of dividing first by second
        //// We do no validation of the arguments so a user may pass in a zero
        //// in place of the second parameter. This is an illegal operation in maths
        //// If we don't validate input or catch the error, the application will crash

        //static int Divide(int first, int second)
        //{
        //    int result = first / second;
        //    return result;
        //}

        // Method Divide() that contains exception handling to deal with
        // divide by zero exceptions

        static int Divide(int first, int second)
        {
            int result = 0;

            try
            {
                result = first / second;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Whoops.\n\nCannot divide by zero, please provide a non-zero value for your second value");
            }

            return result;
        }
    }
}
