using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,digit=0;
            Console.WriteLine("Введите число:");
            number = int.Parse(Console.ReadLine());
            while(number>0)
            {
                number /= 10;
                digit++;
            }
            Console.WriteLine("В данном числе {0} разрядов", digit);
            Console.ReadKey();
        }
    }
}
