using System;
using System.IO.Pipes;

namespace Lab02
{
    public class ClassRoom
    {
        private Pupil[] pupils;
        public ClassRoom(params Pupil[] _pupils) 
        {
            this.pupils = _pupils; 
            for (int i = 0; i < pupils.Length; i++)
            {
                Console.WriteLine($"Information about pupil {i + 1}\n");
                pupils[i].Study();
                pupils[i].Read();
                pupils[i].Write();
                pupils[i].Relax();
            }
        }
    }

    public class Pupil
    {
        public virtual void Study() { Console.WriteLine("I can study"); }
       
        public virtual void Read() { Console.WriteLine("I can read"); }
       
        public virtual void Write() { Console.WriteLine("I can write");  }

        public virtual void Relax() { Console.WriteLine("I can relax");  }
    }

    public class ExcelentPupil : Pupil
    {
        public override void Study() { Console.WriteLine("I can study excelent"); }

        public override void Read() { Console.WriteLine("I can read excelent"); }

        public override void Write() { Console.WriteLine("I can write excelent"); }

        public override void Relax() { Console.WriteLine("I can relax excelent"); }
    }

    public class GoodPupil : Pupil
    {
        public override void Study() { Console.WriteLine("I can study good"); }

        public override void Read() { Console.WriteLine("I can read good"); }

        public override void Write() { Console.WriteLine("I can write good"); }

        public override void Relax() { Console.WriteLine("I can relax good"); }
    }

    public class BadPupil : Pupil
    {
        public override void Study() { Console.WriteLine("I can study bad"); }

        public override void Read() { Console.WriteLine("I can read bad"); }

        public override void Write() { Console.WriteLine("I can write bad"); }

        public override void Relax() { Console.WriteLine("I can relax bad"); }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}