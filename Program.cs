using System;

namespace MultiplyOrDivide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Result: " + number * 3);
            }
            else
            {
                Console.WriteLine("Result: " + (double)number / 2);
            }
        }
    }
}
