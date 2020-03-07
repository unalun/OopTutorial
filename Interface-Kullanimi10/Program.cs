using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Kullanimi10
{
    class Program
    {
        static void Main(string[] args)
        {
            Service productService = new ProductService();
            Console.WriteLine(productService.Add());
            Console.WriteLine(productService.Remove());
            Console.ReadKey();
        }
    }

    public interface Service
    {
        bool Add();
        bool Remove();
    }

    public class ProductService : Service
    {
        public bool Add()
        {
            return true;
        }

        public bool Remove()
        {
            return false;
        }
    }

}
