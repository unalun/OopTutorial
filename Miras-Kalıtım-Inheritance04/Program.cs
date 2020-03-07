using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miras_Kalıtım_Inheritance04
{
    class Program
    {
        static void Main(string[] args)
        {
            Bmw bmw = new Bmw("320d");
            bmw.Gear = true;
            bmw.CarName();
            bmw.GearValue();
            Tofas tofas = new Tofas("kartal");
            tofas.Radio = false;
            tofas.CarName();
            tofas.RadioValue();
            Console.ReadKey();
        }
    }


    public class Car
    {
        private string Name;
        public Car(string name)
        {
            Name = name;
        }
        public void CarName()
        {
            Console.WriteLine("Araba Adı : {0} ", Name);
        }
    }
    public class Bmw : Car
    {
        public Bmw(string name) : base(name)
        {
        }
        public bool Gear { get; set; } // vites
        public void GearValue()
        {
            Console.WriteLine("Otmatik Vites mi : {0} ", Gear);
        }
    }
    public class Tofas : Car
    {
        public Tofas(string name) : base(name)
        {
        }
        public bool Radio { get; set; } // vites
        public void RadioValue()
        {
            Console.WriteLine("Radio Var mı : {0} ", Radio);
        }
    }

}
