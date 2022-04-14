using System;

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дано двузначное число.Определить: 
            // а) какая из его цифр больше, первая или вторая;
            // б) одинаковы ли его цифры. 


            int number;
            int remainder;
            int divided;

            Console.WriteLine("Enter the 2-digits number");
            number = Convert.ToInt32(Console.ReadLine());

            remainder = number % 10;
            divided = number / 10;

            if (number > 99 || number < 10)
            {
                Console.WriteLine("Wrong number");
            }
            else
            {
                Console.WriteLine($"First digit is {divided}");
                Console.WriteLine($"Second digit is {remainder}");
                if (divided > remainder)
                {
                    Console.WriteLine($"{divided} is bigger then {remainder}");
                }
                else if (divided < remainder)
                {
                    Console.WriteLine($"{divided} is less then {remainder}");
                }
                else 
                {
                    Console.WriteLine($"{divided} equals {remainder}");
                }
            }
            Console.ReadLine();
        }
    }
}
