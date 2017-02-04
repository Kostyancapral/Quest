using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_extrasensory
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int N=0,Nr;
            Nr = rand.Next(1, 147);
            while (Nr != N)
            {
                Console.Clear();
                Console.WriteLine("Введите число");
                N = Convert.ToInt32(Console.ReadLine());
                if (Nr > N)
                {
                    Console.WriteLine("Больше");
                    Console.ReadLine();
                }
                else
                {
                    if (Nr < N)
                    {
                        Console.WriteLine("Меньше");
                        Console.ReadLine();
                    }
                }
            }
            Console.WriteLine("Верно");
            Console.ReadLine();
        }
    }
}
