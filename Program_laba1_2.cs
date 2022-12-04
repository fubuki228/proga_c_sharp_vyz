using System;

namespace second
{
    class Program
    {
        class Rectangle
        {
            double? perimeter;
            double? area;
            public double side1;
            public double side2;
            public double? Perimeter { get { return perimeter; } }
            public double? Area { get { return area; } }

            double AreaCalculator() => side1 * side2;
            double PerimeterCalculator() => side1 * 2 + side2 * 2;

            public Rectangle(double sideA, double sideB)
            {
                side1 = sideA;
                side2 = sideB;
                perimeter = PerimeterCalculator();
                area = AreaCalculator();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter sides of rectangle:");
            double side1 = Convert.ToDouble(Console.ReadLine());
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rec = new Rectangle(side1, side2);
            Console.WriteLine($"Perimeter: {rec.Perimeter} {Environment.NewLine}");
            Console.WriteLine($"Area: {rec.Area} {Environment.NewLine}");
        }
    }
}
//Создайте класс с именем Rectangle.
//В теле класса создайте два поля, описывающие длины сторон double side1, side2.
//Создайте пользовательский конструктор Rectangle(double sideA, double sideB), в теле которого поля sideA и sideB инициализируются значениями аргументов.
//Создайте два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр прямоугольника - double PerimeterCalculator().
//Создайте два свойства double Area и double Perimeter с одним методом доступа get.
//Напишите программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь. Покройте тестами методы класса Rectangle