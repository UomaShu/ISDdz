using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer print = new Printer();
        }
    }
    class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine("{0}", value);
        }

        class Red : Printer
        {
            public override void Print(string value)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your title {0}", value);
            }
        }
    }
}
