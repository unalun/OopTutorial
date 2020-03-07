using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatikKullanimi08
{
    class Program
    {

        static void Main(string[] args)
        {
            //https://www.c-sharpcorner.com/blogs/main-method-in-c-sharp
            //projenin başlaması için method statik olmalı ama sınıf statik olmadan zorunda değil
            Console.WriteLine(Tool.Combine("Ünal", "ÜN"));
            Console.ReadKey();
        }


    
    }

    static public class Tool
    {
        public static string Combine(string name, string surName)
        {
            return name + surName;
        }
    }




}






