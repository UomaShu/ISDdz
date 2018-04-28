using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_task_1
{
    class Program
    {
        delegate int Operation(int x, int y,int n);
        static void Main(string[] args)
        {
            Operation operation = delegate (int x, int y,int n)
            {
                return (x + y + n) / 3;
            };
            int d = operation(4, 5, 6);
            Console.WriteLine(d); 
            Console.Read();
        }
    }
}
