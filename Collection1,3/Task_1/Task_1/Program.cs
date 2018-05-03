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
            int[] array = new int[] { 5, 4, 2, 8, 4, 10, 12 };
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.Write("\n");
            Console.WriteLine("Коллекция четных элементов:");
            foreach (var item in MyClass.MyMeth(array))
            {
                Console.Write("{0} ", item);
            }
            Console.Write("\n");
            Console.ReadKey();

        }
    }

       static class  MyClass
    {
        public  static IEnumerable<int> MyMeth(int[] array)
        {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
                yield return array[i];
        }
        }
    }
}
 

