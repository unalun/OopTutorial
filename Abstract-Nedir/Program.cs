using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Nedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Name = "Nisa";
            child.Sleep();

            Young young = new Young();
            young.Name = "Kubra";
            young.Sleep();
            Console.ReadKey();
        }
    }

    public abstract class People
    {
        public string Name { get; set; }
        public abstract void Sleep();
    }
    public class Child : People
    {
        public override void Sleep()
        {
            Console.WriteLine("Child Sleep Time, 21:45");
        }
    }

    public class Young : People
    {
        public override void Sleep()
        {
            Console.WriteLine("Young Sleep Time, 24:00");
        }
    }




}
