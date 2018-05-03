using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class MyList<T> : IEnumerator<T>, IEnumerable<T>
    {
        private int position = -1;
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
        public void Add(T item)
        {
            size += 1;
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
        public void Remove(T item)
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
        public T Current
        {
            get { return array[position]; }
        }
        object IEnumerator.Current
        {
            get { return Current; }
        }
        public void Reset()
        {
            position = -1;
        }
        public bool MoveNext()
        {
            if (position < size - 1)
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }
        public void Dispose()
        {

        }
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
    public static class MyListExtension
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            T[] array = new T[0];
            foreach (T item in list)
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length-1] = item;
            }
            return array;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> mylist = new MyList<int>(5);
            mylist[4] = 11;
            mylist[0] = 5;
            mylist.Add(15);
            mylist.Add(-2);
            Console.WriteLine("Список myList:");
            foreach (int item in mylist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Общее кол-во элементов: {0}", mylist.Count);
            Console.WriteLine("Значение элемента с индексом 2: {0}", mylist[2]);
            Console.WriteLine("Удалим элемент массива со значением 15:");
            mylist.Remove(15);
            foreach (int item in mylist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Общее кол-во элементов: {0}", mylist.Count);
            Console.WriteLine("Удалим элемент массива с индексом 3:");
            mylist.RemoveAt(3);
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Общее кол-во элементов: {0}", mylist.Count);
            Console.WriteLine("Список, возвращенный методом GetArray():");
            for (int i = 0; i < mylist.Count; i++)
            {
                Console.WriteLine(mylist.GetArray()[i]);

            }
            Console.ReadKey();
        }
    }
}
