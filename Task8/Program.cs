using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutesForOnePatient = 10;
            int PatientsPerHour = 6;
            int minutesPerHour = 60;

            Console.WriteLine("Сколько перед вами старушек?");
            int numberOfGrandmoms = int.Parse(Console.ReadLine());

            Console.WriteLine($"Вы должны отстоять в очереди {numberOfGrandmoms/PatientsPerHour} часов {(numberOfGrandmoms*minutesForOnePatient)-((numberOfGrandmoms / PatientsPerHour)*minutesPerHour)} минут");

            Console.ReadLine();

        }
    }
}
