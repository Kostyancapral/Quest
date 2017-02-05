using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "-1";
            while (menu != "0")
            {
                Console.Clear();
                Console.WriteLine("Выберите задание, рузультат которого вы хотите увидеть");
                Console.WriteLine("1 - Таблица умножения");
                Console.WriteLine("2 - Количество разрядов");
                Console.WriteLine("3 - Больше меньше");
                Console.WriteLine("4 - Квадраты меньше числа");
                Console.WriteLine("5 - Сренее арифметическое(клавиатура)");
                Console.WriteLine("6 - Сренее арифметическое(рандом)");
                Console.WriteLine("7 - Гуси и кролики");
                Console.WriteLine("8 - Пароль");
                Console.WriteLine("0 - Выход");
                menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        Process.Start("1\\1 multiplication table.exe");
                        break;
                    case "2":
                        Process.Start("2\\2 number of digits.exe");
                        break;
                    case "3":
                        Process.Start("3\\3 extrasensory.exe");
                        break;
                    case "4":
                        Process.Start("4\\4 pow(2).exe");
                        break;
                    case "5":
                        Process.Start("5\\5 arithmetic average.exe");
                        break;
                    case "6":
                        Process.Start("6\\6 random arithmetik average.exe");
                        break;
                    case "7":
                        Process.Start("7\\7 gangers and rabbits.exe");
                        break;
                    case "8":
                        Process.Start("8\\8 password.exe");
                        break;
                    case "0":
                        break;
                }
            }
        }
    }
}
