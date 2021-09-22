using System;
using System.Linq.Expressions;

namespace tydzien2_lekcja7_zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj numer dnia tygodnia");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("wtorek");
                    break;
                case 3:
                    Console.WriteLine("środa");
                    break;
                case 4:
                    Console.WriteLine("czwartek");
                    break;
                case 5:
                    Console.WriteLine("piątek");
                    break;
                case 6:
                    Console.WriteLine("sobota");
                    break;
                case 7:
                    Console.WriteLine("niedziela");
                    break;
             }
            
            




        }
    }
}
