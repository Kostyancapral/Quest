using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_lotteries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int balance = 100;
            int number=0,value;
            string str="yes";
            while (str=="yes")
            {          
                bool f = false;
                while (f == false)
                {
                    Console.Clear();
                    Console.WriteLine("Ваш баланс " + balance + " очков");
                    Console.WriteLine("Делайте вашу ставку");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (balance - number < 0)
                    {
                        Console.WriteLine("У вас недостаточно очков");
                        Console.ReadLine();
                    }
                    else
                    {
                        f = true;
                    }
                }
                balance -= number;
                value=rand.Next(1, 13);
                if (value <= 5)
                {
                    Console.WriteLine("Очень жаль но вы проиграли");
                }
                else
                {
                    if (value >= 6 && value <= 8)
                    {
                        Console.WriteLine("Вы не выиграли но и не проиграли и вы возвращаете " + number + " очков");
                        balance += number;
                    }
                    else
                    {
                        if (value >= 9 && value <= 11)
                        {
                            Console.WriteLine("Поздравляем, вы выиграли в этой игре и получаете " + number * 2 + " очков");
                            balance += number * 2;
                        }
                        else
                        {
                            Console.WriteLine("ДЖЕКПОТ!!!!! вы получаете десятикратный приз " + number * 10 + " очков");
                            balance += number * 10;
                        }
                    }
                }
                if (balance==0)
                {
                    Console.WriteLine("Очень жаль но очков не осталось");
                    str = "";
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("введите \"yes\" есди хотите продолжить");
                    str=Console.ReadLine();
                }
            }
            Console.Clear();
            Console.WriteLine("Ваш итоговый баланс " + balance + " очков");
            Console.ReadLine();
        }
    }
}
