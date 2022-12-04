using System;

namespace Third
{
    class Program
    {

        class Point
        {
            public int x;
            public int y;


            public Point(int x_, int y_)
            {
                x = x_;
                y = y_;
            }
        }


        class Figure
        {
            public string name;
            Point p1;
            Point p2;
            Point p3;
            Point p4;
            Point p5;
            double perimeter;
            double Perimeter { get { return perimeter; } }
            public int p1_x { get { return p1.x; } }
            public int p1_y { get { return p1.y; } }
            public int p2_x { get { return p2.x; } }
            public int p2_y { get { return p2.y; } }
            public int p3_x { get { return p3.x; } }
            public int p3_y { get { return p3.y; } }
            public int p4_x { get { return p4.x; } }
            public int p4_y { get { return p4.y; } }
            public int p5_x { get { return p5.x; } }
            public int p5_y { get { return p5.y; } }

            public Figure(Point p1_, Point p2_, Point p3_)
            {
                p1 = p1_;
                p2 = p2_;
                p3 = p3_;
                name = "Triangle";


            }

            public Figure(Point p1_, Point p2_, Point p3_, Point p4_)
            {
                p1 = p1_;
                p2 = p2_;
                p3 = p3_;
                p4 = p4_;
                name = "Rectangle";

            }

            public Figure(Point p1_, Point p2_, Point p3_, Point p4_, Point p5_)
            {
                p1 = p1_;
                p2 = p2_;
                p3 = p3_;
                p4 = p4_;
                p5 = p5_;
                name = "Pentagon";

            }

            double LengthSide(Point A, Point B)
            {
                return Math.Pow((A.x - B.x), 2) + Math.Pow((A.y - B.y), 2);
            }
            public double PerimeterCalculator()
            {
                double result = 0;
                result = LengthSide(p1, p2) + LengthSide(p2, p3);
                if (name == "Triangle") result += LengthSide(p1, p3);
                if (name == "Rectangle") result += LengthSide(p3, p4) + LengthSide(p4, p1);
                if (name == "Pentagon") result += LengthSide(p3, p4) + LengthSide(p4, p5) + LengthSide(p5, p1);
                return result;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter count of dots:");
            byte b = Convert.ToByte(Console.ReadLine());
            switch (b)
            {
                case 3:
                    Console.WriteLine("Enter first dot:");
                    Point p13 = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Enter second dot:");
                    Point p23 = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Enter third dot:");
                    Point p33 = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

                    Figure fig1 = new Figure(p13, p23, p33);
                    Console.WriteLine($"Perimeter: {fig1.PerimeterCalculator()}");
                    Console.WriteLine($"Name: {fig1.name}");

                    break;
                case 4:
                    Console.WriteLine("Enter first dot:");
                    Point p14 = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Enter second dot:");
                    Point p24 = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Enter third dot:");
                    Point p34 = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Enter fourth dot:");
                    Point p44 = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

                    Figure fig2 = new Figure(p14, p24, p34, p44);
                    Console.WriteLine($"Perimeter: {fig2.PerimeterCalculator()}");
                    Console.WriteLine($"Name: {fig2.name}");

                    break;
                case 5:
                    Console.WriteLine("Enter first dot:");
                    Point p15 = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Enter second dot:");
                    Point p25 = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Enter third dot:");
                    Point p35 = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Enter fourth dot:");
                    Point p45 = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Enter fifth dot:");
                    Point p55 = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

                    Figure fig3 = new Figure(p15, p25, p35, p45, p55);
                    Console.WriteLine($"Perimeter: {fig3.PerimeterCalculator()}");
                    Console.WriteLine($"Name: {fig3.name}");

                    break;

                default:
                    Console.WriteLine("Wrong Figure!");
                    break;
            }
        }
    }
}
//Создайте классы Point и Figure.
//Класс Point должен содержать два целочисленных поля с координатами точки.
//Создайте два свойства с одним методом доступа get.
//Создайте пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.
//Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point, а также строковое автосвойство для хранения названия фигуры.
//Создайте два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр многоугольника.
//Напишите программу, которая выводит на экран название и периметр многоугольника. Покройте тестами методы класса Figure.