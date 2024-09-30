using System;
using System.IO.Pipes;

namespace Lab02
{
    public class Vehicle
    {
        protected int x, y, price, speed, year;

        public Vehicle(int x, int y, int price, int speed, int year)
        {
            this.x = x;
            this.y = y;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }

        public virtual void Print()
        {
            System.Console.WriteLine($"Coordinates: {x}:{y}\nPrice: {price}\nSpeed: {speed}\nYear: {year}");
        }
    }

    public class Plane : Vehicle
    {
        private double height;
        private int passangers;
     
        public Plane(int x, int y, int price, int speed, int year, double height, int passangers) : base(x, y, price, speed, year)
        {
            this.height = height;
            this.passangers = passangers;
        }

        public override void Print() 
        {
            base.Print();
            System.Console.WriteLine($"Height: {height}\nPassangers: {passangers}\nI am a plane");

        }
    }

    public class Car : Vehicle
    {
        public Car(int x, int y, int price, int speed, int year) : base(x, y, price, speed, year) {}

        public override void Print()
        {
            base.Print();
            System.Console.WriteLine("I am a car");
        }
    }

    public class Ship : Vehicle
    {
        private string port;
        private int passangers;

        public Ship(int x, int y, int price, int speed, int year, string port, int passangers) : base(x, y, price, speed, year) { this.port = port; this.passangers = passangers; }

        public override void Print()
        {
            base.Print();
            System.Console.WriteLine($"Port: {port}\nPassangers: {passangers}\nI am a ship");
        }
    }

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