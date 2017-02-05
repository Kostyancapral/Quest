using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_cat_or_dog
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.Write("Text = ");
            str = Console.ReadLine();
            if (str == "мяу" || str == "Мяу" || str == "МЯУ" || str == "meow" || str == "Meow")
            {
                Console.WriteLine("Покорми кота");
            }
            else
                if (str == "гав" || str == "Гав" || str == "ГАВ" || str == "bow-wow" || str == "Bow-wow")
                {
                    Console.WriteLine("Погуляй с собакой");
                }
                else
                {
                }
            Console.ReadLine();
        }
    }
}
