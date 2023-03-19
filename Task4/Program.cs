using System;

namespace Task4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();

            Console.WriteLine("Сколько вам лет?");
            int years = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Какой у вас знак зодиака?");
            string zodiac = Console.ReadLine();

            Console.WriteLine("Где вы работаете?");
            string workPlace = Console.ReadLine();

            Console.WriteLine("Ваш любимый фрукт?");
            string fruit = Console.ReadLine();

            Console.WriteLine( $"Вас зовут {name}, вам {years} год, вы {zodiac} , вы работаете {workPlace} и ваш любимый фрукт - {fruit}");
        }
    }
}