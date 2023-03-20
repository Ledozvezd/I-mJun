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
            int line = 3;
            int quantityOfStrings = picturesAmount / line;
            int restPics = picturesAmount % line;

            Console.WriteLine("Будет заполнено рядов: " + quantityOfStrings);
            Console.WriteLine("Останется: " + restPics);
        }
    }
}
