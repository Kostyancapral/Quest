using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            int km, min,price;
            Console.WriteLine("какой километраж нужно преодолеть");
            km = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("сколько минут простоя");
            min = Convert.ToInt32(Console.ReadLine());
            price = 20;
            if (km > 5)
            {
                price += (km - 5) * 3;
            }
            price += min;
            Console.WriteLine("Итого цена будет равна "+price+" гривен");
            Console.ReadLine();
        }
    }
}
