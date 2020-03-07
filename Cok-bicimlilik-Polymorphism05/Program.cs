using System;

namespace Cok_bicimlilik_Polymorphism05
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw draw = new Draw();
            Console.WriteLine(draw.Drawing("Square", 300, 400));

            Circle circle = new Circle();
            Console.WriteLine(circle.Area());

            Triangle triangle = new Triangle();
            Console.WriteLine(triangle.Area());

            HighSchool highSchool = new HighSchool();
            Console.WriteLine(highSchool.FullName("nisa", "aybike"));

            Universty universty = new Universty();
            Console.WriteLine(universty.FullName("Sercan","Demirci"));

            Console.ReadKey();
        }
    }

    // Static - Compile Time Polymorphism
    public class Draw
    {
        public string Drawing(string name)
        {
            return "Drawing : " + name;
        }

        //overload
        public string Drawing(string name, int height, int weigth)
        {
            string drawing = string.Format("Name : {0}, Height : {1}, Weight : {2}", name, height, weigth);
            return drawing;
        }
    }

    //Dynamic - Runtime Polymorphism
    public class Drawing
    {
        public virtual string Area()
        {
            return "Square";
        }
    }

    public class Circle : Drawing
    {
        public override string Area()
        {
            return "Circle";
        }
    }


    public class Triangle : Drawing
    {
        public override string Area()
        {
            return "Triangle";
        }
    }


    // base method

    public class  Student
    {
        public virtual string FullName(string name, string surname)
        {
            string fullName = string.Format("{0} {1}", name, surname);
            return fullName;
        }
    }

    public class HighSchool : Student
    {
        public override string FullName(string name, string surname)
        {
            string fullName = base.FullName(name, surname);
            fullName = "Child : " + fullName;
            return fullName;
        }
    }

    public class Universty : Student
    {
        public override string FullName(string name, string surname)
        {
            string fullName = base.FullName(name, surname);
            fullName = "Mr : " + fullName;
            return fullName;
        }
    }
}
