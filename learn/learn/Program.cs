using System;


namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
           /* При запуске программы, должна отобразиться сегодняшняя дата в формате 14.11.2015.
            Чем точнее она будет, тем лучше.Подумайте, как можно это реализовать и добиться максимальной точности.
            Напомню, что системно можно получить количество миллисекунд, прошедших от 01.01.1970 года с момощью метода
            System.currentTimeInMills();*/

            long date;
            int year;
            int month;
            int day;
            int hour;
            int minute;
            int second;

            Console.WriteLine("Enter the 1-4 digits number");

            string timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff");


            Console.WriteLine($"{timestamp}");

            //date = DateTimeOffset(now).FromUnixTimeMilliseconds();
            

            Console.ReadLine();
        }
    }
}
