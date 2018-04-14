using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();
            int randomNumber = randomizer.Next(1,148);
            int userNumber;
            Console.WriteLine("Угадайте число от 1 до 148:");
            do
            {
                Console.WriteLine("Введите число:");
                userNumber = int.Parse(Console.ReadLine());
                if (userNumber < randomNumber)
                {
                    Console.WriteLine("Больше");
                }                    
                else if (userNumber > randomNumber)
                {
                    Console.WriteLine("Меньше");
                }
                    
                else if (userNumber == randomNumber)
                {
                    Console.WriteLine("Угадал");
                }  
            } while (userNumber!=randomNumber);
            Console.ReadKey();
        }
    }
}
