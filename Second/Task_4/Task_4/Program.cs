using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Rectangle rectangle = new Rectangle(12, 20);
            double key=rectangle.Side1;
            double key2 = rectangle.Side2;
            Console.WriteLine("Ваш периметр : {0}, ваша площадь : {1}",rectangle.PerimetrCalculator(),rectangle.AreaCalculator());*/



            /*Content content = new Content();
            content.content = "About elphs";

            Title title = new Title();
            title.title = "This is title";

            Author author = new Author();
            author.author = "Kafka";

            Book book = new Book();
            book._author = author;
            book._content = content;
            book._title = title;
            book.Show();*/

            Point A = new Point(1, 1, "A");
            Point B = new Point(10, 10, "B");
            Point C = new Point(-10, -10, "C");
            Point D = new Point(10, -10, "D");
            Point E = new Point(-10, 10, "E");


            Figure figure1, figure2, figure3;

            figure1 = new Figure(A, B, C);
            figure2 = new Figure(A, B, C, D);
            figure3 = new Figure(A, B, C, D, E);

            try
            {

                figure1.PerimetrCalculator();
                figure2.PerimetrCalculator();
                figure3.PerimetrCalculator();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
    class Figure
    {
        private Point A = null, B = null, C = null, D = null, E = null;

        public Figure(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.E = E;
        }
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Abs((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y)));
        }
        public void PerimetrCalculator()
        {
            if ((D == null) && (E == null))
            {
                double periment = LengthSide(A, B) + LengthSide(B, C) + LengthSide(A, C);
                Console.WriteLine("Ur perimetr {0} and ur name {1},{2},{3}", periment, A.yourStr, B.yourStr, C.yourStr);
            }
            if (E == null && D != null)
            {
                double periment = LengthSide(A, B) + LengthSide(A, D) + LengthSide(B, C) + LengthSide(C, D);
                Console.WriteLine("Ur perimetr {0} and ur name {1},{2},{3},{4}", periment, A.yourStr, B.yourStr, C.yourStr, D.yourStr);
            }
            if (D != null && E != null)
            {
                double periment = LengthSide(A, C) + LengthSide(A, B) + LengthSide(B, E) + LengthSide(E, D) + LengthSide(C, D);
                Console.WriteLine("Ur perimetr {0} and ur name {1},{2},{3},{4},{5}", periment, A.yourStr, B.yourStr, C.yourStr, D.yourStr, E.yourStr);
            }
        }

    }
    class Point
    {
        private int _x;
        private int _y;
        private String pStr;

        public int X
        {
            get => _x;
        }
        public int Y
        {
            get => _y;
        }
        public String yourStr
        {
            get => pStr;
        }
        public Point(int x, int y, String pStr)
        {
            this._x = x;
            this._y = y;
            this.pStr = pStr;
        }
    }
}
