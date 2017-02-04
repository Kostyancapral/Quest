using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_number_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, digits=0;
            Console.WriteLine("Введите число");
            N = Convert.ToInt32(Console.ReadLine());
            do
            {
                digits++;
                N /= 10;
            }
            while (N != 0);
            Console.WriteLine("Число разрядов: " + digits);
            Console.ReadLine();
        }     
    }
}
