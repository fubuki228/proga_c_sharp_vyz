using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Pupil
    {
        public int stu, rea, wri, rel;// 0 or 1 or 2
        public string perfomance = "undef";//  B or G or E

        public string DeterminePerfomance()
        {
            if (stu == 0 || rea == 0 || wri == 0 || rel == 0) return "Bad";
            else if (stu == 2 && rea == 2 && wri == 2 && rel == 2) return "Excellent";
            else return "Good";
        }
        public Pupil()
        {
            Random rnd = new Random();
            stu = rnd.Next(0, 3);
            rea = rnd.Next(0, 3);
            wri = rnd.Next(0, 3);
            rel = rnd.Next(0, 3);

            perfomance = DeterminePerfomance();
        }

        public Pupil(int _stu, int _rea, int _wri, int _rel)
        {
            stu = _stu;
            rea = _rea;
            wri = _wri;
            rel = _rel;

            perfomance = DeterminePerfomance();
        }
        public virtual void Study() { ++stu; }

        public virtual void Read() { ++rea; }

        public virtual void Write() { ++wri; }

        public virtual void Relax() { ++rel; }

        public virtual void Print()
        {
            Console.WriteLine($"Study = {stu}  Read = {rea}  Wri = {wri}  Relax = {rel}\nType: {perfomance}");
        }

    }

    class ExcelentPupil : Pupil
    {

        public override void Study() { }
        public override void Read() { }
        public override void Write() { }
        public override void Relax() { }
    }

    class GoodPupil : Pupil
    {

        public override void Study() { base.Study(); }
        public override void Read() { base.Read(); }
        public override void Write() { base.Write(); }
        public override void Relax() { base.Relax(); }
    }

    class BadPupil : Pupil
    {
        public override void Study() { base.Study(); ++stu; }
        public override void Read() { base.Read(); ++rea; }
        public override void Write() { base.Write(); ++wri; }
        public override void Relax() { base.Relax(); ++rel; }
    }

    class ClassRoom : Pupil
    {
        List<Pupil> classList = new List<Pupil>();
        public ClassRoom(params Pupil[] students)
        {
            foreach (Pupil n in students) { classList.Add(n); }
        }

        public new void Print()
        {
            foreach (var n in classList) { n.Print(); }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pupil masha = new Pupil();
            Pupil kostya = new Pupil(2, 1, 1, 2);
            Pupil misha = new Pupil(2, 2, 2, 2);
            ClassRoom room = new ClassRoom(masha, kostya, misha);
            room.Print();
            Console.Read();
        }
    }
}
