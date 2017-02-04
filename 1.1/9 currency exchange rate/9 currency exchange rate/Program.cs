using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_currency_exchange_rate
{
    class Program
    {
        static void Main(string[] args)
        {
            double uan=0, usd=0, eur=0;
            const double uantousd=0.037, uantoeur=0.034, usdtoeur=0.93;
            double value;
            Console.WriteLine("Введите сумму");
            value = Convert.ToDouble(Console.ReadLine());
            int menu;
            Console.WriteLine("Выберите валюту введенной суммы");
            Console.WriteLine("1 - гривна");
            Console.WriteLine("2 - евро");
            Console.WriteLine("3 - доллар");
            menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1: uan = value; break;
                case 2: eur = value; break;
                case 3: usd = value; break;
            }
            if (menu == 1)
            {
                Console.WriteLine("Гривны: " + Math.Round(uan,2));
                usd = uan * uantousd;
                eur = uan * uantoeur;
                Console.WriteLine("Доллары: " + Math.Round(usd,2));
                Console.WriteLine("Евро: " + Math.Round(eur,2));
            }
            if (menu == 2)
            {
                Console.WriteLine("Евро: " + Math.Round(eur, 2));
                uan = eur / uantoeur;
                usd = eur / usdtoeur;
                Console.WriteLine("Гривны: " + Math.Round(uan, 2));
                Console.WriteLine("Доллары: " + Math.Round(usd, 2));
            }
            if (menu == 3)
            {
                Console.WriteLine("Доллары: " + Math.Round(usd, 2));
                uan = usd / uantousd;
                eur = usd * usdtoeur;
                Console.WriteLine("Гривны: " + Math.Round(uan, 2));
                Console.WriteLine("Евро: " + Math.Round(eur, 2));
            }
            Console.ReadLine();
        }
    }
}
