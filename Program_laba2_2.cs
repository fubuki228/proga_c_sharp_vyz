using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    class Vehicle
    {
        public int speed;
        public int year;
        public int cost;

        public Vehicle()
        {
            speed = 0;
            year = 0;
            cost = 0;
        }
        public Vehicle(int s, int y, int c)
        {
            speed = s;
            year = y;
            cost = c;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Vehicle:\nSpeed = {speed}   Year = {year}   Cost = {cost}   ");
        }
    }
    class Plane : Vehicle
    {
        public int height;
        public int capacity;

        public Plane() : base()
        {
            height = 0;
            capacity = 0;
        }
        public Plane(int s, int y, int c, int h, int cap) : base(s, y, c)
        {
            height = h;
            capacity = cap;
        }

        public new void Print()
        {
            Console.WriteLine($"Plane:\nSpeed = {speed}   Year = {year}   Cost = {cost}   Height = {height}   Capacity = {capacity}");
        }
    }
    class Ship : Vehicle
    {
        public int capacity;
        public string adress;

        public Ship() : base()
        {
            capacity = 0;
            adress = "Home";
        }
        public Ship(int s, int y, int c, int cap, string home) : base(s, y, c)
        {
            capacity = cap;
            adress = home;
        }

        public new void Print()
        {
            Console.WriteLine($"Ship:\nSpeed = {speed}   Year = {year}   Cost = {cost}   Adress = {adress}   Capacity = {capacity}");
        }
    }
    class Car : Vehicle
    {
        //?
        public new void Print()
        {
            Console.WriteLine($"Car:\nSpeed = {speed}   Year = {year}   Cost = {cost}   ");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Plane P = new Plane(1000, 2000, 5, 1000, 5000);
            P.Print();
            Ship S = new Ship(100, 1950, 10, 500, "Sweet Home Alabama");
            S.Print();
            Car C = new Car();
            C.Print();

            Console.Read();
        }
    }
}