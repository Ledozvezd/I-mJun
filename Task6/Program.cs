using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int picturesAmount = 52;
            Console.WriteLine("Будет заполнено рядов: " + picturesAmount/3);
            Console.WriteLine("Останется: " + picturesAmount % 3);
            Console.ReadLine();
        }
    }
}
