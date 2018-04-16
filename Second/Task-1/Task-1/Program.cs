using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Address
    {
        private string  country, city, street;
        private int index, house, apartment;
        
        public int Index
        {
            get
            {               
                return index;
            }

            set
            {
                index = value;
            }
        }

        public int House
        {
            get
            {
                return house;
            }

            set
            {
                house = value;
            }
        }

        public int Apartment
        {
            get
            {
                return apartment;
            }

            set
            {
                apartment = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string Street
        {
            get
            {
                return street;
            }

            set
            {
                street = value;
            }
        }

 class Program
    {
        static void Main(string[] args)
        {

                Address address = new Address();
                Console.WriteLine("Напишите ваш индекс");
                address.index = int.Parse(Console.ReadLine());
                Console.WriteLine("Напишите номер вашего дома");
                address.house = int.Parse(Console.ReadLine());
                Console.WriteLine("Напишите номер вашей квартиры");
                address.apartment = int.Parse(Console.ReadLine());
                Console.WriteLine("Напишите страну в который вы проживаете");
                address.country = Console.ReadLine();
                Console.WriteLine("Напишите город в котором вы проживаете");
                address.city = Console.ReadLine();
                Console.WriteLine("Напишите улицу в которой вы проживаете");
                address.street = Console.ReadLine();

                Console.WriteLine("Страна:{0}", address.country);
                Console.WriteLine("Город:{0}", address.city);
                Console.WriteLine("Улица:{0}", address.street);
                Console.WriteLine("Дом:{0}", address.house);
                Console.WriteLine("Квартира:{0}", address.apartment);
                Console.WriteLine("Индекс:{0}", address.index);
                Console.ReadKey();
            }
    }

    }
}
