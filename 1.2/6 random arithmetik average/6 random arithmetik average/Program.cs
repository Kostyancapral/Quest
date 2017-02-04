using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_arithmetic_average
{
    class Program
    {      
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] N = new int[5];
            double average = 0;
            for (int i = 0; i < 5; i++)
            {
                N[i] = rand.Next(-10000,10000);
                average += N[i];
            }
            average /= 5;
            Console.WriteLine("Среднее арифметическое=" + average);
            Console.ReadLine();
        }
    }
}
