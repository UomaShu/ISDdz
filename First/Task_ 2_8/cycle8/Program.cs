using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cycle8
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass;
            string chek = "root";
                Console.WriteLine("Напишите правильный пароль");
                pass= Console.ReadLine();

            while (pass != chek)
            {
                pass = Console.ReadLine();
                
                
            }

            Console.WriteLine("Вы ввели верный пароль");


        }
    }
}
