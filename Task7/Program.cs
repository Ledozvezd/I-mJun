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
            int amountOfCoins = Convert.ToInt32((Console.ReadLine()));

            Console.WriteLine("Сколько хотите купить кристалов?");
            int quantityOfDiamods = Convert.ToInt32((Console.ReadLine()));

            int restOfMoney = amountOfCoins - (quantityOfDiamods*moneyCourse);

            Console.WriteLine($"У вас {quantityOfDiamods} кристалов");
            Console.WriteLine($"У вас осталось {restOfMoney} монет");

            Console.ReadLine();
        }
    }
}
