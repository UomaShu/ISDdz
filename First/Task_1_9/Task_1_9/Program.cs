using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyAmount;
            string type;
            Console.WriteLine("Ведите сумму денег:");
            moneyAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("Ведите тип валюты(гривна, доллар, евро):");
            type = Console.ReadLine();
            switch (type)
            {
                case "гривна":
                    Console.WriteLine("{0} гривен-{1} долларов",moneyAmount,Math.Round(moneyAmount/26.27,2));
                    Console.WriteLine("{0} гривен-{1} евро",moneyAmount,Math.Round(moneyAmount/32.52,2));
                    break;
                case "доллар":
                    Console.WriteLine("{0} долларов-{1} гривен", moneyAmount, Math.Round(moneyAmount * 25.88, 2));
                    Console.WriteLine("{0} долларов-{1} евро", moneyAmount, Math.Round(moneyAmount * 0.8, 2));
                    break;
                case "евро":
                    Console.WriteLine("{0} евро-{1} гривен", moneyAmount, Math.Round(moneyAmount * 31.78, 2));
                    Console.WriteLine("{0} евро-{1} долларов", moneyAmount, Math.Round(moneyAmount * 1.21, 2));
                    break;
                default:
                    Console.WriteLine("Неверный тип валюты!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
