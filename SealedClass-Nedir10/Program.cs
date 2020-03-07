using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass_Nedir10
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Library1
    {
        public bool X()
        {
            return true;
        }
    }

    // sealed sınıf kalıtım alabilir
    public sealed class Library2 : Library1
    {
        public bool Y()
        {
            return true;
        }
    }

    // sealed sınıf olan Library2 den kalıtım alamaz
    // hatalıdır.
    //public class ProductOperation : Library2
    //{
    //    public bool Z()
    //    {
    //        return true;
    //    }
    //}


    //-----------------------------------------------------------------------------------
    //ORNEK 1
    // normal virtual ile işaretlenmiş bir method override edilerek ezilebiliyor.

    public class A
    {
        public virtual void X()
        {

        }
    }

    public class B : A
    {
        public override void X()
        {
            Console.WriteLine("B sınıfındaki X metodu çalıştı");
        }
    }

    //ORNEK 2
    //public class X
    //{
    //    public virtual void Message()
    //    {

    //    }
    //}

    //public class Y : X
    //{
    //    public sealed override void Message()
    //    {
    //        Console.WriteLine("X sınıfındaki Message metodu çalıştı");
    //    }
    //}

    //public class Z : Y
    //{
    //    override    
    //}






}
