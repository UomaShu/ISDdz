using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("У гусей и кроликов 64 лапы. Всего может быть:");
            for (int i=1; i<=16; i++)
            {
                for (int j=1; j<=32; j++)
                {
                    if (4*i+2*j==64)
                    {
                        Console.WriteLine("{0} кроликов,{1} гусей",i,j);
                    }
                }
            }
            Console.ReadKey();                  
        }
    }
}
