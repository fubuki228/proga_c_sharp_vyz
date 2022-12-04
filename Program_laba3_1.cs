using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    struct Vector
    {
        int X;
        int Y;
        int Z;

        public Vector(int _x, int _y, int _z)
        {
            X = _x;
            Y = _y;
            Z = _z;
        }
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector { X = v1.X + v2.X, Y = v1.Y + v2.Y, Z = v1.Z + v2.Z };
        }

        public static double operator *(Vector v1, Vector v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        public static Vector operator *(int k, Vector v1)
        {
            return new Vector { X = v1.X * k, Y = v1.Y * k, Z = v1.Z * k };
        }
        public static Vector operator *(Vector v1, int k) { 
       
            return (k * v1);
        }
        public static bool operator &(Vector v1, Vector v2)
        {
            bool v1_flag = !(v1.X == 0 && v1.Y == 0 && v1.Z == 0);
            bool v2_flag = !(v2.X == 0 && v2.Y == 0 && v2.Z == 0);
            return v1_flag & v2_flag;
        }
        public static bool operator |(Vector v1, Vector v2)
        {
            bool v1_flag = !(v1.X == 0 && v1.Y == 0 && v1.Z == 0);
            bool v2_flag = !(v2.X == 0 && v2.Y == 0 && v2.Z == 0);

            return v1_flag | v2_flag;
        }

        public static bool operator ^(Vector v1, Vector v2)
        {
            bool v1_flag = !((v1.X == 0) && (v1.Y == 0));
            bool v2_flag = !((v2.X == 0) && (v2.Y == 0));

            return v1_flag ^ v2_flag;
        }
        public static bool operator !(Vector v)
        {
            return (v.X == 0 && v.Y == 0 && v.Z == 0);
        }

        public void Print()
        {
            Console.WriteLine($"{X},{Y},{Z}");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vector A = new Vector(3, 4, 5);
            Vector B = new Vector(25, 9, 16);

            Vector C = A + B;
            A.Print(); B.Print();
            Console.WriteLine($"A+B = "); C.Print();
            Console.WriteLine($"A*B = {A * B}");
            C = A * 3;
            Console.WriteLine($"A*3 = \t"); C.Print();
            Console.WriteLine($"A&B = {A & B}");
            Console.WriteLine($"A|B = {A | B}");
            Console.WriteLine($"A^B = {A ^ B}");
            Console.WriteLine($"!A ={!A}");
        }
    }
}
