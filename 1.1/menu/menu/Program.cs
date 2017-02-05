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
            while(menu!="0")
            {
                Console.Clear();
                Console.WriteLine("Выберите задание, рузультат которого вы хотите увидеть");
                Console.WriteLine("1 - Большее число");
                Console.WriteLine("2 - ГавМяу");
                Console.WriteLine("3 - Пора года");
                Console.WriteLine("4 - Плохо или хорошо");
                Console.WriteLine("5 - День недели");
                Console.WriteLine("6 - Такси");
                Console.WriteLine("7 - Простое ли число");
                Console.WriteLine("8 - Лоторея");
                Console.WriteLine("9 - Курс валют");
                Console.WriteLine("0 - Выход");
                menu=Console.ReadLine();
                switch (menu)
                {
                    case "1": 
                        Process.Start("1\\1 greater number.exe");
                        break;
                    case "2":
                        Process.Start("2\\2 cat or dog.exe");
                        break;
                    case "3":
                        Process.Start("3\\3 time of year.exe");
                        break;
                    case "4":
                        Process.Start("4\\4 good or bad.exe");
                        break;
                    case "5":
                        Process.Start("5\\5 weekday.exe");
                        break;
                    case "6":
                        Process.Start("6\\6 taxi.exe");
                        break;
                    case "7":
                        Process.Start("7\\7 prime number.exe");
                        break;
                    case "8":
                        Process.Start("8\\8 lotteries.exe");
                        break;
                    case "9":
                        Process.Start("9\\9 currency exchange rate.exe");
                        break;
                    case "0": 
                        break;
                }
            }
        }
    }
}
