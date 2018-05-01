using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Task_3
{
    class MyDictionary<TKey, TValue>
    {
        private List<Item<TKey, TValue>> items = new List<Item<TKey, TValue>>();
        public TKey key;
        public TValue value;
        private int count = 0;
        public void addElement(TKey key, TValue value)
        {

            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (items.Any(i => i.Key.Equals(key)))
            {
                throw new ArgumentException($"Словарь уже содержит значение с ключом {key}.", nameof(key));
            }


            var item = new Item<TKey, TValue>()
            {
                Key = key,
                Value = value
            };


            items.Add(item);
            count++;
        }
        public int getCount()
        {
            return count;
        }
        public TValue Get(TKey key)
        {

            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }


            var item = items.SingleOrDefault(i => i.Key.Equals(key)) ??
                throw new ArgumentException($"Словарь не содержит значение с ключом {key}.", nameof(key));


            return item.Value;
        }
    }
}
