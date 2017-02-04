using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_greater_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b;
            Console.Write("First number = ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Second number = ");
            b = Double.Parse(Console.ReadLine());
            Console.Write("Greater number = ");
            if(a>b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
            Console.ReadLine();
        }
    }
}
