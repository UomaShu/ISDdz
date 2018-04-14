using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycle1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Введите число N");
            N = int.Parse(Console.ReadLine());

            for(int i=1;i<=20;i++)
            {
                Console.WriteLine(N*i);
            }
        
        }
    }
}
