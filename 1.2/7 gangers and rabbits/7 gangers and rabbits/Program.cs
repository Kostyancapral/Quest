using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_gangers_and_rabbits
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 64;
            int R; int G;
            R = 0; G = 32;
            while(G>=0)
            {
                Console.WriteLine("Кроликов = " + R + "\tГусей = " + G);
                G -= 2;
                R += 1;
            }
            Console.ReadLine();
        }
    }
}
