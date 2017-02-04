using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_time_of_year
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Введите номер месяца: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number == 12 || number == 1 || number == 2)
            {
                Console.WriteLine("Зима");
            }
            else
            {
                if (number == 3 || number == 4 || number == 5)
                {
                    Console.WriteLine("Весна");
                }
                else
                {
                    if (number == 6 || number == 7 || number == 8)
                    {
                        Console.WriteLine("Лето");
                    }
                    else
                    {
                        if (number == 9 || number == 10 || number == 11)
                        {
                            Console.WriteLine("Осень");
                        }
                        else
                        {
                            Console.WriteLine("На этой планете такого месяца нет");
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
