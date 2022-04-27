using System;
using System.Globalization;

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Программа считает среднее арифметическое вводимых с клавиатуры чисел. 
             *  Сначала программа предлагает ввести количество этих чисел, 
             *  а потом предлагает непосредственно вводить эти числа. 
             *  Ответ должен быть округлен по правилу округления.
             */

            int amountNums;
            int sum = 0;
            decimal result;

            Console.WriteLine("Enter the amount of numbers: ");
            amountNums = Convert.ToInt32(Console.ReadLine());


            for(int i = 1; i<=amountNums; i++)
            {
                Console.WriteLine($"Enter {i} number: ");
                int temp = Convert.ToInt32(Console.ReadLine());

                sum += temp;
            }

            result = sum / Convert.ToDecimal(amountNums);
            Console.WriteLine($" {result} ");


            Console.WriteLine($"Result is {decimal.Round(result)} ");


            Console.ReadLine();
        }
    }
}
