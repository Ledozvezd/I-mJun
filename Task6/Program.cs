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
            int picturesQuantity = 52;
            int picsPerLine = 3;
            int quantityOfStrings = picturesQuantity / picsPerLine;
            int restPics = picturesQuantity % picsPerLine;

            Console.WriteLine("Будет заполнено рядов: " + quantityOfStrings);
            Console.WriteLine("Останется: " + restPics);
        }
    }
}
