using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_good_or_bad
{
    class Program
    {
        static void Main(string[] args)
        {
            int F;
            string str;
            F = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(str = (F==1) ? "Хорошо" : "Плохо");
            Console.ReadLine();
        }
    }
}
