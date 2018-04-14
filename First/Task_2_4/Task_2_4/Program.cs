using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, square;
            Console.WriteLine("Ведите число:");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Кваадраты натуральных чисел, которые меньше введенного числа:");
            for (int i=1; (square=i*i)<number; i++)
            {
                Console.WriteLine(square);
            }
            Console.ReadKey();
        }
    }
}
