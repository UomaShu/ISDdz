using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct myStruct = new MyStruct();
            MyClass myClass = new MyClass();
            MyStruct.StruktTaker(myStruct);
            MyClass.ClassTaker(myClass);
        }
    }
    struct MyStruct
    {
        public string change;
        public static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "Измененно";
        }
    }
    class MyClass
    {
        public string change;
        public static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Измененно";
        }
    }
}
