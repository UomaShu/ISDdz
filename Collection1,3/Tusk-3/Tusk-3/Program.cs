using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusk_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(0, "string");
            dictionary.Add(1, "string1");
            dictionary.Add(2, "string2");
            dictionary.Add(3, "string3");
            dictionary.Add(4, "string4");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
    class MyDictionary<Tkey, Tval>: IEnumerable<KeyValuePair<Tkey,Tval>>
    {
        private int counter = 0;
        private Tkey[] keysArray = null;
        private Tval[] valsArray = null;
        
        public int Counter
        {
            get { return this.counter; }
        }

        public void Add(Tkey key, Tval val)
        {
            this.counter++;

            Array.Resize(ref keysArray, counter);
            keysArray[counter - 1] = key;

            Array.Resize(ref valsArray, counter);
            valsArray[counter - 1] = val;
        }

        public Tval this[Tkey key]
        {
            get
            {
                int ind = 0;
                for (int i = 0; i < keysArray.Length; i++)
                {
                    if (key.Equals(keysArray[i]))
                        ind = i;
                }
                return valsArray[ind];
            }
        }
        public IEnumerator<KeyValuePair<Tkey, Tval>> GetEnumerator()
        {
            for (int i = 0; i < keysArray.Length; i++)
                yield return new KeyValuePair<Tkey, Tval>(keysArray[i], valsArray[i]);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
