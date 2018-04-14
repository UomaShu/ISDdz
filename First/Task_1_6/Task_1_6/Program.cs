using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes, kilometers, price=20;
            Console.WriteLine("Ведите количество километров:");
            kilometers = int.Parse(Console.ReadLine());
            Console.WriteLine("Ведите количество минут простоя:");
            minutes = int.Parse(Console.ReadLine());
            if (kilometers<=5)
            {
                Console.WriteLine("Цена поездки {0} гривен",price);
            }
            else
            {
                price +=(kilometers-5)*3+minutes;
                Console.WriteLine("Цена поездки {0} гривен", price);
            }
            Console.ReadKey();
        }
    }
}
