using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c = 0;
            char d;
            int p;
            Console.WriteLine("1 = calculator \n 2 - exit \n");
            p = int.Parse(Console.ReadLine());
            while (p != 2)
            {
                switch (p)
                {
                    case 1:
                        {
                            Console.WriteLine("first number");
                            a = int.Parse(Console.ReadLine());

                            Console.WriteLine("Action with numbers");
                            d = char.Parse(Console.ReadLine());

                            Console.WriteLine("Second number");
                            b = int.Parse(Console.ReadLine());

                            if (d == '+')
                                Calc.Plus(a, b);
                            else if (d == '-')
                                Calc.Minus(a, b);
                            else if (d == '*')
                                Calc.Multiply(a, b);
                            else if (d == '/')
                                Calc.Share(a, b);
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                }

            }
        }
    }
    static class Calc
    {
        public static void Plus(float a, float b)
        {
            Console.WriteLine("Result:{0}", a + b);
        }
        public static void Minus(float a, float b)
        {
            Console.WriteLine("Result:{0}", a - b);
        }
        public static void Multiply(float a, float b)
        {
            Console.WriteLine("Result:{0}", a * b);
        }
        public static void Share(float a, float b)
        {
            Console.WriteLine("Result:{0}", a / b);
        }


    }
}
