using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Nedir06
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            phone.Name = "Samsung";

            Console.WriteLine(phone.Name);

            CellPhone cellPhone = new CellPhone();
            cellPhone.Name = "Iphone";

            Console.WriteLine(cellPhone.Name);
            Console.ReadKey();
        }
    }


    internal struct Phone
    {
        public string Name { get; set; }

        public Phone(string name)
        {
            Name = name;
        }

        //kullandığımız property constructor da kullanıyorsak belirtmeliyiz
        //public string Model { get; set; }

        //Parametresiz Yapıcı Method Constructor tanımı yapılmaz    
        //public Phone()
        //{

        //}
    }

    internal struct CellPhone
    {
        public string Name { get; set; }
        public string Model { get; set; }
    }





}
