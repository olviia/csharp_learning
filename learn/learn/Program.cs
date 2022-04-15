using System;

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Дано четырехзначное число.Определить: 
            а) равна ли сумма двух первых его цифр сумме двух его  последних цифр;
            б) кратна ли трем сумма его цифр;
            в) кратно ли четырем произведение его цифр;
            г) кратно ли произведение его цифр числу а.
            */

            int input_number;
            int a_number;
            int first_number;
            int second_number;
            int third_number;
            int forth_number;

            Console.WriteLine("Enter the 4-digits number");
            input_number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number");
            a_number = Convert.ToInt32(Console.ReadLine());

            if (input_number>999  || input_number < 10000)
            {
                forth_number = input_number % 10;
                third_number = ((input_number - forth_number) / 10) % 10;
                second_number = ((input_number - forth_number - third_number * 10) / 100) % 10;
                first_number = ((input_number - forth_number - third_number * 10 - second_number * 100) / 1000) % 10;

                if(first_number+second_number == third_number + forth_number)
                {
                    Console.WriteLine($"sum of first and second digits equals sum of third and forth digits");
                }
                else
                {
                    Console.WriteLine($"sum of first and second digits not equals sum of third and forth digits");
                }

                if((first_number+second_number+third_number+forth_number) % 3 == 0)
                {
                    Console.WriteLine($"sum of all digits is multiple of 3");
                }
                else 
                {
                    Console.WriteLine($"sum of all digits is not multiple of 3");
                }

                if((first_number*second_number*third_number*forth_number) % 4 == 0)
                {
                    Console.WriteLine($"product of all digits is multiple of 4");
                }
                else 
                {
                    Console.WriteLine($"product of all digits is not multiple of 4");
                }

                if((first_number*second_number*third_number*forth_number) % a_number == 0)
                {
                    Console.WriteLine($"product of all digits is multiple of {a_number}");
                }
                else 
                {
                    Console.WriteLine($"product of all digits is not multiple of {a_number}");
                }
            }

            Console.ReadLine();
        }
    }
}
