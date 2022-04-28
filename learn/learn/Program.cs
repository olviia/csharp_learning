using System;
using System.Globalization;

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Задача 11.
            Придумать алгоритм "старых досовских" программ. Программа может повторять свои действия. >
            Программа вычисляет степень введенного числа.
            Введите число: 
            > 7
            > Введите степень, которую необходимо вычислить:
            > 4
            > 7 в степени 4 равно 2401 
            Хотите продолжить? Да - введите 1, нет - введите 0
             */
            StartProgramm();
        }
        static void StartProgramm()
        {
            bool repeat = true;
            while (repeat)
            {
                PowerOfNumber();
                repeat = AnswerCheck();
            }

            Console.WriteLine("Thank you for using this programm!");
            Console.ReadLine();
        }
        static void PowerOfNumber()
        {
            double number;
            double power;
            double result;

            Console.WriteLine("Enter the number:");
            number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the power of number:");
            power = Convert.ToDouble(Console.ReadLine());

            result = Math.Pow(number, power);
            Console.WriteLine($"{number}^{power}={result}");
        }

        static bool AnswerCheck()
        {
            string answer;
            Console.WriteLine("Do you want to continue programm? Enter yes or no");
            answer = Console.ReadLine();

            if(answer == "yes")
            {
                return true;
            } else if(answer == "no")
            {
                return false;
            }
            else
            {
                Console.WriteLine("You entered incorrect input. Try again");
                return AnswerCheck();
            }
        }
    }
}
