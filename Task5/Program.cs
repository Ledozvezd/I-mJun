using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Иванов";
            string surname = "Миша";
            Console.WriteLine(name + ' ' + surname);
            (name, surname) = (surname, name);
            Console.WriteLine(name + ' ' +  surname);
        }
    }
}
