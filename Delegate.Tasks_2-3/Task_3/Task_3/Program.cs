using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public delegate int Number();
    public delegate int Medium(Number[] array);  
    class Program
    {
        static Random rand = new Random();
        public static int Randomizer()
        {
            return rand.Next(1, 10);
        }
        static void Main(string[] args)
        {
            Number[] array = new Number[5];
            for (int i=0; i<array.Length; i++)
            {
                array[i] = Randomizer;
            }
            Console.WriteLine("Сгенерированные числа:");
            Medium mediumValue = delegate (Number[] numArray)
             {
                 int sum = 0;
                 int arrayElem;
                 for (int i = 0; i < numArray.Length; i++)
                 {
                     arrayElem = numArray[i]();
                     Console.WriteLine(arrayElem);
                     sum += arrayElem;
                 }
                 return ((sum) / (numArray.Length));
             };
            Console.WriteLine("Среднее арифметическое:{0}", mediumValue(array));
            Console.ReadKey();
        }
    }
}
