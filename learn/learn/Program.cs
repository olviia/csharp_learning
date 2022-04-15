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
            37 - оканчивается нечетным, оканчивается на 7, является нечетным. 48 - оканчивается четным, не оканчивается на 7, является четным
            switch (remainder)
            {
                case 7:
                    Console.WriteLine("Number is uneven, finished with 7, finished with uneven digit");
                    break;
                case 1:
                    Console.WriteLine("Number is uneven, finished not with 7, finished with uneven digit");
                    break;
                case 3:
                    Console.WriteLine("Number is uneven, finished not with 7, finished with uneven digit");
                    break;
                case 5:
                    Console.WriteLine("Number is uneven, finished not with 7, finished with uneven digit");
                    break;
                case 9:
                    Console.WriteLine("Number is uneven, finished not with 7, finished with uneven digit");
                    break;
                case 2:
                    Console.WriteLine("Number is even, finished not with 7, finished with even digit");
                    break;
                case 4:
                    Console.WriteLine("Number is even, finished not with 7, finished with even digit");
                    break;
                case 6:
                    Console.WriteLine("Number is even, finished not with 7, finished with even digit");
                    break;
                case 8:
                    Console.WriteLine("Number is even, finished not with 7, finished with even digit");
                    break;
                case 0:
                    Console.WriteLine("Number is even, finished not with 7, finished with even digit");
                    break;
                default:
                    Console.WriteLine("Something goes wrong");
                    break;
            }



            Console.ReadLine();
        }
    }
}
