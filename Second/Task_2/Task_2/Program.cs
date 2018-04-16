using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator()
        {
            return side1 * side2;
        }
        public double PerimetrCalculator()
        {
            return 2 * (side1 + side2);
        }
        public double Side1
        {
            get
            {
                return this.side1;
            }
        }
        public double Side2
        {
            get
            {
                return this.side2;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(12, 20);
            double key = rectangle.Side1;
            double key2 = rectangle.Side2;
            Console.WriteLine("Ваш периметр : {0}, ваша площадь : {1}", rectangle.PerimetrCalculator(), rectangle.AreaCalculator());
        }
    }
}
