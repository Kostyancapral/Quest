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
            int[] N=new int [5];
            double average=0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("N["+Convert.ToString(i+1)+"]=");
                N[i] = Convert.ToInt32(Console.ReadLine());
                average += N[i];
            }
            average/=5;
            Console.WriteLine("Среднее арифметическое=" + average);
            Console.ReadLine();
        }
    }
}
