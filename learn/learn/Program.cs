using System;

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "January",
                                "Fabryary",
                                "March", 
                                "April", 
                                "May", 
                                "June", 
                                "July", 
                                "August", 
                                "September", 
                                "October", 
                                "November", 
                                "December"};
            int number;

            Console.WriteLine("Enter the number of month");
            number = Convert.ToInt32(Console.ReadLine());

            if(number <= 12 && number >= 1)
            {
                Console.WriteLine(months[number - 1]);
            }
            else
            {
                Console.WriteLine("Input was wrong");
            }

            Console.ReadLine();
        }
    }
}
