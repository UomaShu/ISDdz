using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    static class ArrayExtension
    {
        public static void ArraySort(this int[] array)
        {
            int temp;
            for(int i=0; i<array.Length-1; i++)
            {
                for (int j=i+1; j<array.Length; j++)
                {
                    if (array[i]>array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 2, 6, 4, 12, 34, 22, 18 };
            Console.WriteLine("Неотсортированый массив:");
            for (int i=0; i<array.Length;i++)
            {
                Console.Write(array[i]+" ");
            }
            Console.Write("\n");
            array.ArraySort();
            Console.WriteLine("Отсортированый по возрастанию массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
