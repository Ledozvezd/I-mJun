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
            int amountOfFull = picturesAmount / 3;
            int tooMuchPics = picturesAmount % 3;

            Console.WriteLine("Будет заполнено рядов: " + amountOfFull);
            Console.WriteLine("Останется: " + tooMuchPics);
        }
    }
}
