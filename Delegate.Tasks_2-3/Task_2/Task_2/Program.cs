using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        public delegate double Operations(double x, double y);
        static void Main(string[] args)
        {
            string sign;
            double x, y, result;
            Operations Add = (a, b) => a + b;
            Operations Sub = (a, b) => a - b;
            Operations Mul = (a, b) => a * b;
            Operations Div = (a, b) => b==0 && a<0 ? double.NegativeInfinity : b==0 ? double.PositiveInfinity:a/b;
            Console.WriteLine("Ввведите первое число:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ведите ввторое число:");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите действие: +, -, *,/ ");
            sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    result = Add(x, y);
                    Console.WriteLine("Ответ:{0}",result);                    
                    break;
                case "-":
                    result = Sub(x, y);
                    Console.WriteLine("Ответ:{0}", result);
                    break;
                case "*":
                    result = Mul(x, y);
                    Console.WriteLine("Ответ:{0}", result);
                    break;
                case "/":
                    result = Div(x, y);
                        Console.WriteLine("Ответ:{0}", result);
                    break;
                default:
                    Console.WriteLine("Неверный ввод");
                    break;                               
            }
            Console.ReadKey();
        }
    }
}
