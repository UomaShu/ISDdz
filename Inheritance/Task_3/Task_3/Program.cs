using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Vehicle
    {
        private double cordinateX, cordinateY, price, speed, constructionYear;
        public double CoordinateX
        {
            get { return cordinateX; }
            set { cordinateX = value; }
        }

        public double CoordinateY 
        {
            get { return cordinateY; }
            set { cordinateY = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public double Year
        {
            get { return constructionYear; }
            set { constructionYear = value; }
        }
        public Vehicle(double price, double speed, double constructionYear)
        {
            this.price = price;
            this.speed = speed;
            this.constructionYear = constructionYear;
        }

    }
    class Plane:Vehicle
    {
        private double height;
        private int passengers;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Passengers
        {
            get { return passengers; }
            set { passengers = value; }            
        }
        public Plane(double price, double speed, double constructionYear, double height, int passengers)
            :base(price,speed,constructionYear)
        {
            this.height = height;
            this.passengers = passengers;
        }
    }
    class Car:Vehicle
    {
        public Car(double price, double speed, double constructionYear)
            :base(price,speed,constructionYear)
        {

        }
    }
    class Ship:Vehicle
    {
        private int passengers;
        private string port;
        public int Passenger
        {
            get { return passengers; }
            set { passengers = value; }
        }
        public string Port
        {
            get { return port; }
            set { port = value; }
        }
        public Ship(double price, double speed, double constructionYear, string port, int passengers)
            :base(price,speed,constructionYear)
        {
            this.port = port;
            this.passengers = passengers;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Самолёт:");
            var plane = new Plane(20000, 500, 2001, 9, 700);
            Console.WriteLine("Год выпуска: {0}", plane.Year);
            Console.WriteLine("Стоимость самолёта: {0} грн.", plane.Price);
            Console.WriteLine("Высота полёта: {0} км.", plane.Height);
            Console.WriteLine("Число пассажиров: {0}", plane.Passengers);
            Console.WriteLine("Скорость: {0} км/ч", plane.Speed);
            Console.WriteLine("Машина:");
            var car = new Car(16000, 160, 2010);           
            Console.WriteLine("Стоимость машины: {0} грн.", car.Price);
            Console.WriteLine("Год выпуска: {0}", car.Year);
            Console.WriteLine("Скорость: {0} км/ч", car.Speed);
            Console.WriteLine("Корабль:");
            var ship = new Ship(100000, 200, 2005, "Порт Мария", 1000);
            Console.WriteLine("Стоимость корабля: {0} грн.", ship.Price);
            Console.WriteLine("Год выпуска: {0}", ship.Year);
            Console.WriteLine("Скорость: {0} км/ч", ship.Speed);
            Console.WriteLine("Порт приписки: {0}", ship.Port);
            Console.ReadKey();
        }
    }
}
