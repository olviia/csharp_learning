using System;

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "January - month of winter",
                                "Fabryary - month of winter",
                                "March - month of spring",
                                "April - month of spring",
                                "May - month of spring",
                                "June - month of summer",
                                "July - month of summer",
                                "August - month of summer",
                                "September - month of autumn",
                                "October - month of autumn",
                                "November - month of autumn",
                                "December - month of winter"};
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
