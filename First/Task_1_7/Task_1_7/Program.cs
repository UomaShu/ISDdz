using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            bool isPrime = true;
            Console.WriteLine("Введите число");
            n = int.Parse(Console.ReadLine());
            
            for (i = 2; i <= (Math.Sqrt(Math.Abs(n))); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
                Console.WriteLine("This is a prime number"); 
            else
                Console.WriteLine("This is not a prime number"); 
        }
    }
}
