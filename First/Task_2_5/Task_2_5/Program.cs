using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum=0;
            int integerNumber;
            Console.WriteLine("Ведите 5 целых чисел:");
            for (int i=1; i<=5; i++)
            {
                Console.WriteLine("Ведите {0} число",i);
                integerNumber = int.Parse(Console.ReadLine());
                Sum += integerNumber;
            }
            Console.WriteLine("Среднее арифметическое: {0}", Sum/5);
            Console.ReadKey();
        }
    }
}
