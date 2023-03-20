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
            int minutesPerHour = 60;
            int PatientsPerHour = minutesPerHour/ minutesForOnePatient;
            
            Console.WriteLine("Сколько перед вами старушек?");
            int numberOfGrandmoms = int.Parse(Console.ReadLine());

            int hours = numberOfGrandmoms / PatientsPerHour;
            int minutes = (numberOfGrandmoms * minutesForOnePatient) - (hours * minutesPerHour);

            Console.WriteLine($"Вы должны отстоять в очереди {hours} часов {minutes} минут");
        }
    }
}
