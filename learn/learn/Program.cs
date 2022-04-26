using System;
using System.Globalization;

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Дополнить предыдущую задачу, при помощи конструкций выбора сделать 
             * так, чтобы он выводил дату в формате: 
             * День - 14, месяц - ноябрь, год - 2015, день недели - суббота. 
             */

                        int year;
                        string month;
                        int day;
                        string dayOfWeek;


            DateTime dateCurrent = DateTime.Now;

            year = dateCurrent.Year;
            month = dateCurrent.ToString("MMMM", CultureInfo.InvariantCulture);
            day = dateCurrent.Day;
            dayOfWeek = dateCurrent.DayOfWeek.ToString();


            Console.WriteLine($"Day - {day},  Month - {month}, year - {year}, day of week - {dayOfWeek}");

            Console.ReadLine();
        }
    }
}
