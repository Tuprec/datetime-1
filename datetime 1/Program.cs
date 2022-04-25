using System;

namespace datetime_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime tijd = new DateTime(2022, 4, 19);

            Console.WriteLine(tijd.ToShortDateString());
            Console.WriteLine(tijd.ToLongDateString());
            Console.WriteLine(tijd.ToString());
            Console.WriteLine($"{tijd.Day}/{tijd.Month}");
            Console.WriteLine($"{tijd.ToShortDateString()} T {tijd.TimeOfDay} timezone");
            Console.WriteLine(tijd.ToString("R"));
            Console.WriteLine(tijd.ToShortTimeString());
            Console.WriteLine(tijd.ToLongTimeString());
            Console.WriteLine($"{tijd.Month}/{tijd.Year}");
        }
    }
}
