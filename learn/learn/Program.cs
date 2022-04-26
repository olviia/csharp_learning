using System;
using System.Globalization;

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            /* "Умножение без умножения". 
             * Считать с клавиатуры 2 числа и вычислить 
             * их умножение не используя математическое операцию *
             */
            double firstNum;
            double secondNum;
            double multiple = 0;

            Console.WriteLine("Enter the first number: ");
            firstNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            secondNum = Convert.ToDouble(Console.ReadLine());


            if ((firstNum >= 0 && secondNum >= 0)|| (firstNum <= 0 && secondNum >= 0))
            {
                for (int i = 1; i <= secondNum; i++)
                {
                    multiple += firstNum;
                }
            } else if(firstNum <= 0 && secondNum <= 0)
            {
                
                for (int i = 1; i <= -secondNum; i++)
                {
                    multiple -= firstNum;
                }
            }else if(firstNum >= 0 && secondNum <= 0)
            {
                
                for (int i = 1; i <= firstNum; i++)
                {
                    multiple += secondNum;
                }
            } else
            {
                Console.WriteLine("Input was wrong");
            }

            Console.WriteLine($"Multiple of {firstNum} and {secondNum} is {multiple}");


            Console.ReadLine();
        }
    }
}
