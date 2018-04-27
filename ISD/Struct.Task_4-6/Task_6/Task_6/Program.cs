using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{    
    public enum Post
    {
        Welder=160,
        Mechanic=120,
        Accountant=180,
        Engineer=200
    }
    public class Accauntant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if((int)worker>hours)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int hours,choice;
            Post worker;
            Accauntant prize = new Accauntant();
            Console.WriteLine("Выберите свою должность:");
            Console.WriteLine("1.Сварщик");
            Console.WriteLine("2.Механик");
            Console.WriteLine("3.Бухгалтер");
            Console.WriteLine("4.Инженер");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите отработаное количество часов за месяц:");
            hours = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    worker = Post.Welder;
                    if (prize.AskForBonus(worker, hours))
                    {
                        Console.WriteLine("Вам положена премия!");
                    }
                    else
                    {
                        Console.WriteLine("Извините, в этом месяце без премии.");
                    }
                    break;
                case 2:
                    worker = Post.Mechanic;
                    if (prize.AskForBonus(worker, hours))
                    {
                        Console.WriteLine("Вам положена премия!");
                    }
                    else
                    {
                        Console.WriteLine("Извините, в этом месяце без премии.");
                    }
                    break;
                case 3:
                    worker = Post.Accountant;
                    if (prize.AskForBonus(worker, hours))
                    {
                        Console.WriteLine("Вам положена премия!");
                    }
                    else
                    {
                        Console.WriteLine("Извините, в этом месяце без премии.");
                    }
                    break;
                case 4:
                    worker = Post.Engineer;
                    if (prize.AskForBonus(worker, hours))
                    {
                        Console.WriteLine("Вам положена премия!");
                    }
                    else
                    {
                        Console.WriteLine("Извините, в этом месяце без премии.");
                    }
                    break;
                default:
                    Console.WriteLine("Неверный ввод");
                    break;
            }
            Console.ReadKey();                     
        }
    }
}
