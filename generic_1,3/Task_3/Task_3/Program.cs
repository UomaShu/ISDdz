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
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.addElement(11, "String");
            myDictionary.addElement(12, "Value");
            int count = myDictionary.getCount();
            Console.WriteLine(count);
            string temp = myDictionary.Get(11);
            Console.WriteLine(temp);
        }
    }
}
