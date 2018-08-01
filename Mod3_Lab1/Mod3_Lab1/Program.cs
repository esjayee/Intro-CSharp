using System;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main()
        {
            int result = Sum(20, 45);
            Console.WriteLine($"Calling Sum() with 2 arguments, result is: {result}");

            int result3 = Sum(10, 5, 26);
            Console.WriteLine($"Calling Sum() with 3 arguments, result is: {result3}");

            double dblResult = Sum(20.5, 30.75);
            Console.WriteLine($"Calling Sum() that takes 3 doubles result in: {dblResult}");
        }

        //// Sum() method that takes two integer arguments and sums them
        //// The method returns no value which is why we use void
        //// We also need to use static in the method signature because Main is static
        //// and you cannot call a non-static method from a static method

        //static void Sum(int first, int second)
        //{
        //    int sum = first + second;
        //    Console.WriteLine($"The sum of {first} and {second} is: {sum}");
        //}

        // Sum() method that takes two integer arguments and sums them
        // The method returns an integer value which is why we use int in the signature
        // We also need to use static in the method signature because Main is static
        // and you cannot call a non-static method from a static method

        static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;
        }

        // Sum() method that takes three integer arguments and sums them and then returns the value
        // This method uses the same name as the Sum() method that takes two integers
        // but the parameters here indicate the method is expecting three integers as arguments
        // The compiler knows which method to call based on the number of arguments passed in

        static int Sum(int first, int second, int third)
        {
            int sum = first + second + third;
            return sum;
        }

        // Sum() method that takes two doubles as arguments
        // This method uses the same name as the Sum() method that takes two integers
        // but the parameters here indicate the method is expecting two doubles as arguments
        // The compiler knows which method to call based on the number of arguments passed in
        static double Sum(double first, double second)
        {
            double result = first + second;
            return result;
        }
    }
}
