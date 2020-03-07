using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Kapsulleme03
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Name = "Unal UN";

            car.Message();
            Console.ReadKey();
        }
    }
}
