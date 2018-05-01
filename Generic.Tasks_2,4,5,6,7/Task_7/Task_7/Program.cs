using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class ArrayList
    {
        private Object[] array;
        private int size;
        public ArrayList ()
        {
            size = 0;
            array = new Object[0];
        }
        public ArrayList(int count)
        {
            size = count;
            array = new Object[count];
        }
        public int Count
        {
            get { return size; }
        }
        public Object this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
        public void Add(Object item)
        {
            size += 1;
            Array.Resize(ref array, size);
            array[size - 1] = item;
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                size -= 1;
                for (int i = index; i < size; i++)
                {
                    array[i] = array[i + 1];
                }
                Array.Resize(ref array, size);
            }
        }
        public void Remove(Object item)
        {
            int index = Array.IndexOf(array, item);
            if (index == -1)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                RemoveAt(index);
            }
        }
        public void Reverse()
        {
            Array.Reverse(array);
        }
        public void CopyTo(Object[] array)
        {
            this.array.CopyTo(array, 0);
        }
        public void Insert(int index, Object item)
        {
            if (index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                array[index] = item;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add("строка");
            array.Add(1);
            array.Add(2.3);
            Console.WriteLine("ArrayList:");
            for (int i=0; i<array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Удалим строку из списка:");
            array.Remove("строка");
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Отраазим элементы списка в обратном порядке:");
            array.Reverse();
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
