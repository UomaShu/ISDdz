using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class MyList<T>
    {
        private int size;
        private T[] array;
        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
        public int Count
        {
            get { return size; }
        }       
        public MyList()
        {
            size = 0;
            array = new T[0];
        }
        public MyList(int count)
        {
            size = count;
            array = new T[count];
        }
        public void Add (T item)
        {
            size+=1;
            Array.Resize(ref array, size);
            array[size - 1] = item;
        }
        public void Insert(int index, T item)
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
        public void RemoveAt (int index)
        {
            if (index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                size -= 1;
                for (int i=index; i<size;i++)
                {
                    array[i] = array[i + 1];
                }
                Array.Resize(ref array, size);
            }            
        }
        public void Remove (T item)
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
    }
    static class MyListExtension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = new T[list.Count];
            for (int i=0;i<array.Length; i++)
            {
                array[i] = list[i];
            }
            return array;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList <int> mylist= new MyList<int>(5);
            mylist[4] = 11;
            mylist[0] = 5;
            mylist.Add(15);
            Console.WriteLine("Список myList:");
            for (int i=0; i<mylist.Count;i++)
            {
                Console.WriteLine(mylist[i]);
            }
            Console.WriteLine("Общее кол-во элементов: {0}", mylist.Count);
            Console.WriteLine("Значение элемента с индексом 2: {0}", mylist[2]);
            Console.WriteLine("Значения элементов массива,которые вернул метод GetAray:");
            for (int i=0;i<mylist.Count;i++)
            {
                Console.WriteLine(mylist.GetArray()[i]);
            }
            Console.WriteLine("Удалим элемент массива со значением 15:");
            mylist.Remove(15);
            for (int i = 0; i < mylist.Count; i++)
            {
                Console.WriteLine(mylist.GetArray()[i]);
            }
            Console.WriteLine("Общее кол-во элементов: {0}", mylist.Count);
            Console.WriteLine("Удалим элемент массива с интдексом 3:");
            mylist.RemoveAt(3);
            for (int i = 0; i < mylist.Count; i++)
            {
                Console.WriteLine(mylist.GetArray()[i]);
            }
            Console.WriteLine("Общее кол-во элементов: {0}", mylist.Count);
            Console.ReadKey();
        }
    }
}
