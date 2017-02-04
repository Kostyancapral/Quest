using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_weekday
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekday = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
            int number;
            string str;
            Console.WriteLine("введите порядковый номер");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(str = (number >= 1 && number <= 7) ? weekday[number - 1] : "такого дня недели нет");
            Console.ReadLine();
        }
    }
}
