using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string zodiac;
            int age;
            string work;

            Console.Write("Введити ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ваш знак зодиака: ");
            zodiac = Console.ReadLine();
            Console.Write("Введи вашу должность: ");
            work = Console.ReadLine();

            Console.WriteLine($"Здравствуйте {name}, " +
                $"мы рады вас приветсвовать на должности {work}, ему {age} и " +
                $"по горосокпу он {zodiac}");

            Console.ReadLine();
        }
    }
}
