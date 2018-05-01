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
        }
    }
    public class MyClass<T> where T : new()
    {
        public static T FacrotyMethod()
        {
            return new T();
        }
    }
}
