using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int bet, diceValue;
            Console.WriteLine("Ведите ставку:");
            bet = int.Parse(Console.ReadLine());
            diceValue = rnd.Next(1, 12);
            Console.WriteLine("Бросаю кубик:{0}",diceValue);
            if(diceValue>=1 && diceValue<=5)
            {
                Console.WriteLine("Вы проиграли");
            }
            else if (diceValue >= 6 && diceValue <= 8)
            {
                Console.WriteLine("Вы выиграли {0}", bet);
            }
            else if (diceValue >= 9 && diceValue <= 11)
            {
                Console.WriteLine("Вы выиграли {0}", bet*2);
            }
            else
            {
                Console.WriteLine("Вы выиграли {0}", bet*10);
            }
            Console.ReadKey();
        }
    }
}
