using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public class Converter
    {
        private double hryvna,dollar,euro;
        public Converter(double usd, double eur, double uah)
        {
            dollar = usd;
            hryvna = uah;
            euro = eur;
        }
        public double Uah
        {
            get
            {
                return hryvna;
            }
        }
        public double Usd
        {
            get
            {
                return dollar;
            }
        }
        public double Eur
        {
            get
            {
                return euro;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            double uah, usd, eur;
            int choice;
            Console.WriteLine("Введите сумму в гривнах:");
            uah = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сумму в долларах:");
            usd = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сумму в евро:");
            eur = double.Parse(Console.ReadLine());
            Converter convert = new Converter(usd,eur,uah);
            Console.WriteLine("Выберите вид конвертации:");
            Console.WriteLine("1.гривна-доллар");
            Console.WriteLine("2.гривна-евро");
            Console.WriteLine("3.доллар-гривна");
            Console.WriteLine("4.евро-гривна");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("{0} гривен - {1} долларов", convert.Uah, Math.Round(convert.Uah/25.99,2));
                    break;
                case 2:
                    Console.WriteLine("{0} гривен - {1} евро", convert.Uah, Math.Round(convert.Uah / 32.02, 2));
                    break;
                case 3:
                    Console.WriteLine("{0} долларов - {1} гривен", convert.Usd, Math.Round(convert.Usd*26.2, 2));
                    break;
                case 4:
                    Console.WriteLine("{0} евро - {1} гривен", convert.Eur, Math.Round(convert.Eur * 32.4, 2));
                    break;
                default:
                    Console.WriteLine("Некорректный ввод!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
