using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            
            Console.WriteLine("Введите два числа для выяснения большего из них");
            Console.WriteLine("\n Первое число:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Второе число:");
            b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Число {0} больше чем число {1}",a, b);
            }
            else
                Console.WriteLine("Число {0} больше чем число {1}",b, a);
            Console.ReadLine();
        }
    }
    
}
