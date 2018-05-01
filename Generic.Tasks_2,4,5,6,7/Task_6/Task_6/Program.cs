using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Dictionary <Tkey, Tvalue>
    {
        private int size;
        private Tkey[] keyArray=null;
        private Tvalue[] valArray=null;
        public Dictionary ()
        {
            size = 0;
            keyArray = new Tkey[0];
            valArray = new Tvalue[0];
        }
        public Dictionary (int size)
        {
            this.size = size;
            keyArray = new Tkey[size];
            valArray = new Tvalue[size];
        }
        public int Count
        {
            get { return size; }
        }
        public Tkey[] Keys
        {
            get { return keyArray; }
        }
        public Tvalue[] Values
        {
            get { return valArray; }
        }
        public Tvalue this[Tkey key]
        {
            get
            {
                int index = 0;
                for (int i = 0; i < keyArray.Length; i++)
                {
                    if (key.Equals(keyArray[i]))
                    {
                        index = i;
                    }
                }
                return valArray[index];
            }
        }
        public bool ContainsKey(Tkey key)
        {
            bool flag = false;
            for (int i = 0; i < keyArray.Length; i++)
            {
                if (key.Equals(keyArray[i]))
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public bool ContainsValue(Tvalue value)
        {
            bool flag = false;
            for (int i = 0; i < valArray.Length; i++)
            {
                if (value.Equals(valArray[i]))
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public void Add(Tkey key, Tvalue value)
        {
            size += 1;
            Array.Resize(ref keyArray, size);
            keyArray[size - 1] = key;
            Array.Resize(ref valArray, size);
            valArray[size - 1] = value;
        }
        public void Remove (Tkey key)
        {
            int index = Array.IndexOf(keyArray, key);
            if (index==-1)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                size -= 1;
                for (int i=index; i<size; i++)
                {
                    keyArray[i] = keyArray[i + 1];
                    valArray[i] = valArray[i + 1];
                }
                Array.Resize(ref keyArray, size);
                Array.Resize(ref valArray, size);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(0, "ноль");
            myDictionary.Add(1, "один");
            myDictionary.Add(2, "два");
            Console.WriteLine("Созданная коллекция:");
            for(int i=0; i<myDictionary.Count;i++)
            {
                Console.WriteLine($"{myDictionary.Keys[i]} {myDictionary.Values[i]}");
            }
            Console.WriteLine($"Пара соответствующая ключу 2: {myDictionary[2]}");
            Console.WriteLine($"Коллекция содержит ключ 1: {myDictionary.ContainsKey(1)}");
            Console.WriteLine($"Коллекция содержит значение шесть: {myDictionary.ContainsValue("шесть")}");
            Console.WriteLine("Удалим элемент из коллекции со значением ключа 0:");
            myDictionary.Remove(0);
            for (int i = 0; i < myDictionary.Count; i++)
            {
                Console.WriteLine($"{myDictionary.Keys[i]} {myDictionary.Values[i]}");
            }
            Console.ReadKey();
        }
    }
}
