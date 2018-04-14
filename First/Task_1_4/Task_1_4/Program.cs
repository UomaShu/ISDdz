using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Введите 1 или 0:");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine((number == 1) ? "Хорошо" : "Плохо");
            Console.ReadKey();
        }
    }
}
