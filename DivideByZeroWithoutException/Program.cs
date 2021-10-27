using System;

namespace DivideByZeroWithoutException
{
    public class Program
    {
        static void Main(string[] args)
        {
            // get numerator
            Console.Write("Please enter an integer numerator: ");
            double numerator = Convert.ToDouble(Console.ReadLine());

            // get denominator
            Console.Write("Please enter an integer denominator: ");
            double denominator = Convert.ToDouble(Console.ReadLine());

            // divide the two integers, then display the result
            double result = numerator / denominator;
            Console.WriteLine("The result of " + numerator + " / " + denominator + " is: " + result);
        }
    }
}
