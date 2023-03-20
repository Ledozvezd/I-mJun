using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moneyCourse = 5;

            Console.WriteLine("Сколько у вас монет?");
            int quantityOfCoins = Convert.ToInt32((Console.ReadLine()));

            Console.WriteLine("Сколько хотите купить кристалов?");
            int quantityOfDiamods = Convert.ToInt32((Console.ReadLine()));

            quantityOfCoins -= (quantityOfDiamods*moneyCourse);

            Console.WriteLine($"У вас {quantityOfDiamods} кристалов");
            Console.WriteLine($"У вас осталось {quantityOfCoins} монет");

            Console.ReadLine();
        }
    }
}
