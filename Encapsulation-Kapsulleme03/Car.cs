using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Kapsulleme03
{
    public class Car
    {
        private string _name { get; set; }
        public string Name 
        {
            get 
            {
                if (_name == null || _name == "" )
                {
                    _name = "bilinmiyor";
                }
                return _name;
            } 
            set 
            {
                _name = value;
            }
        }

        public void Message()
        {
            Console.Write("Adı : " + _name);
        }
    }




}




