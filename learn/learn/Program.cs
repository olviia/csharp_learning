using System;

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int remainder;

            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());

            remainder = number % 10;

            switch (remainder)
            {
                case 7:
                    Console.WriteLine("Number is uneven, finished with 7");
                    break;
                case 1:
                    Console.WriteLine("Number is uneven, finished with 1");
                    break;
                case 3:
                    Console.WriteLine("Number is uneven, finished with 3");
                    break;
                case 5:
                    Console.WriteLine("Number is uneven, finished with 5");
                    break;
                case 9:
                    Console.WriteLine("Number is uneven, finished with 9");
                    break;
                case 2:
                    Console.WriteLine("Number is even, finished with not 7, finished with 2");
                    break;
                case 4:
                    Console.WriteLine("Number is even, finished with not 7, finished with 4");
                    break;
                case 6:
                    Console.WriteLine("Number is even, finished with not 7, finished with 6");
                    break;
                case 8:
                    Console.WriteLine("Number is even, finished with not 7, finished with 8");
                    break;
                case 0:
                    Console.WriteLine("Number is even, finished with not 7, finished with 0");
                    break;
                default:
                    Console.WriteLine("Something goes wrong");
                    break;
            }



            Console.ReadLine();
        }
    }
}
