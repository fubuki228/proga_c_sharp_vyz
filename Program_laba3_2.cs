using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    class Car : IEquatable<Car>
    {
        public string Name;
        public string Engine;
        public int MaxSpeed;

        public Car(string _name, string _engine, int _maxspeed)
        {
            Name = _name;
            Engine = _engine;
            MaxSpeed = _maxspeed;
        }
        public override string ToString()
        {
            return Name;
        }

        public bool Equals(Car other)
        {
            if (other == null) return false;

            if (this.Name != other.Name) return false;
            if (this.Engine != other.Engine) return false;
            if (this.MaxSpeed != other.MaxSpeed) return false;
            else return true;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static bool operator ==(Car obj1, Car obj2)
        {
            return obj1.Equals(obj2);
        }
        public static bool operator !=(Car obj1, Car obj2)
        {
            return !(obj1 == obj2);
        }

        public string this[int index]
        {
            get { return Name + Engine; }
        }
    }

    class CarsCatalog
    {
        List<Car> catalog = new List<Car>();//СОЗДАЁМ МАССИВ машин закидываем в него машины и обращаемся к машине

        public CarsCatalog(params Car[] cars)
        {
            foreach (Car n in cars) { catalog.Add(n); }
        }

        public string this[int index]
        {
            get { return catalog[index].Name + " " + catalog[index].Engine; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car A = new Car("Tesla", "Electro", 250);
            Car B = new Car("Honda", "Petrol", 200);
            Car C = new Car("Mercedes", "Diesel", 300);
            CarsCatalog log = new CarsCatalog(A, B, C);

            Console.WriteLine(log[1]);
        }
    }
}
