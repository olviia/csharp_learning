using System;

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, sum;
            Console.WriteLine("Enter the first number");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            b = Convert.ToDouble(Console.ReadLine());

            sum = a + b;
            Console.WriteLine($"The sum is {sum}");
            Console.ReadLine();
        }
    }
}
