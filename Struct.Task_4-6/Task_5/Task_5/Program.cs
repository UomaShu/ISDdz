using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    enum Colors
    {
        Green,
        Red,
        Blue,
        Cyan,
        Magenta
    }
    static class StaticClass
    {
        public static void Print(string stroka, int color)
        {
            switch (color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(stroka);
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(stroka);
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(stroka);
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(stroka);
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(stroka);
                    break;
                default:
                    break;
            }

        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int choice;
            Console.WriteLine("Программа позволяет выводить заданную строку выбранным цветом.");
            Console.WriteLine("Доступные цвета:");
            string[] colorNames = Colors.GetNames(typeof(Colors));
            for (int i=0; i<colorNames.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, colorNames[i]);
            }
            Console.WriteLine("Введите строку:");
            str = Console.ReadLine();
            Console.WriteLine("Ведиет номер цвета:");
            choice = int.Parse(Console.ReadLine());
            StaticClass.Print(str, choice);           
            Console.ReadKey();
        }
    }
}
