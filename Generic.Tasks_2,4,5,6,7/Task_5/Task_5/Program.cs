using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Car
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return $"{Name} {Year}";
        }
    }
    class CarCollection<T> where T: Car, new()
    {
        private List<T> Cars = new List<T>();
        public T this[int index]
        {
            get { return Cars[index]; }
            set { Cars[index] = value; }
        }
        public int Count
        {
            get { return Cars.Count; }
        }
        public void Add(string name, int year)
        {
            Cars.Add(new T() { Name = name, Year = year });
        }
        public void Clear()
        {
            Cars.Clear();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> carCollection = new CarCollection<Car>();
            carCollection.Add("Lada", 1967);
            carCollection.Add("Dacia", 2001);
            carCollection.Add("Skoda", 2014);
            Console.WriteLine("Коллекция машин:");
            Console.WriteLine(carCollection.Count);
            for (int i=0; i<carCollection.Count;i++)
            {
                Console.WriteLine(carCollection[i]);
            }
            Console.WriteLine("Очищаем коллекцию");
            carCollection.Clear();
            Console.WriteLine("Коллекция очищена");
            Console.ReadKey();
        }
    }
}
