using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_password
{
    class Program
    {
        static void Main(string[] args)
        {
            string str="", password="root";
            while (str != password)
            {
                Console.Clear();
                Console.WriteLine("Введите пароль");
                str = Console.ReadLine();
                if (str != password)
                {
                    Console.WriteLine("Неверный пароль");
                    Console.ReadLine();
                }
            }
            Console.Clear();
            Console.WriteLine("Угу =)");
            Console.ReadLine();
        }
    }
}
