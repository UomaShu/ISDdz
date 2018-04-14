using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Кого вы изображаете ? Кошку или Собаку? для выбора напишите либо мяу либо гав");
            string chek = Console.ReadLine();
            switch (chek)
            {
                case "мяу":
                    Console.WriteLine("Покорми кота");
                    break;

                case "гав":
                    Console.WriteLine("Погуляй с собакой");
                    break;

                default:
                    Console.WriteLine("А ну повтори!");
                    break;

            }

        }
    }
}
