using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int Sum = 0;
            int integerNumber;
            Console.WriteLine("Программа создает 5 случайных целых чисел:");
            for (int i = 1; i <= 5; i++)
            {
                integerNumber = rnd.Next(1,100);
                Sum += integerNumber;
                Console.WriteLine("{0} число: {1}", i, integerNumber);   
            }
            Console.WriteLine("Среднее арифметическое: {0}", Sum / 5);
            Console.ReadKey();
        }
    }
}
