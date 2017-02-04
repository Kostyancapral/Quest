using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Введите число");
            N = Convert.ToInt32(Console.ReadLine());
            int cur = 0, i = 1;
            while (i * i < N)
            {
                cur = i * i;
                i++;
                Console.Write(cur+"\t");
            }
            Console.ReadLine();
        }
    }
}
