using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            UInt32 number;
            bool Prime = true;
            Console.WriteLine("Введите простое число");
            number = Convert.ToUInt32(Console.ReadLine());
            double stop = Math.Sqrt(number);
            if (number % 2 == 0)
            {
                Prime = false;
            }
            else
            {
                for (int i = 3; i <= stop; i += 2)
                {
                    if (number % i == 0)
                    {
                        Prime = false;
                        break;
                    }
                }
            }
            string str;
            Console.WriteLine(str = (Prime)? "Простое": "Не простое");
            Console.ReadLine();
        }
    }
}
