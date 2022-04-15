using System;

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
               /* Проверка деления введенного числа на 3.
                Число делится на 3, если сумма всех цифр делится на 3.
                Например: число 174 делится на 3, 
                поскольку сумма его цифр 1 + 7 + 4 = 12 делится на 3.
                Написать программу для любого вводимого числа от 0 до 1000*/

            int input_number;
            int first_number = 0;
            int second_number = 0;
            int third_number = 0;
            int forth_number = 0;

            Console.WriteLine("Enter the 1-4 digits number");
            input_number = Convert.ToInt32(Console.ReadLine());

            if (input_number > 999 || input_number < 10000)
            {
                forth_number = input_number % 10;
                third_number = ((input_number - forth_number) / 10) % 10;
                second_number = ((input_number - forth_number - third_number * 10) / 100) % 10;
                first_number = ((input_number - forth_number - third_number * 10 - second_number * 100) / 1000) % 10;
            }
            else if (input_number > 99 || input_number < 1000)
            {
                third_number = input_number % 10;
                second_number = ((input_number - third_number) / 10) % 10;
                first_number = ((input_number - second_number - third_number * 10) / 100) % 10;
            }
            else if (input_number > 9 || input_number < 100)
            {
                second_number = input_number % 10;
                first_number = ((input_number - second_number) / 10) % 10;
            }
            else if (input_number >= 0 || input_number < 10)
            {
                first_number = input_number;
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }

            if ((first_number+second_number+third_number+forth_number)%3 == 0)
            {
                Console.WriteLine($"{input_number} is multiple of 3");
            }
            else
            {
                Console.WriteLine($"{input_number} is not multiple of 3");
            }

            Console.ReadLine();
        }
    }
}
