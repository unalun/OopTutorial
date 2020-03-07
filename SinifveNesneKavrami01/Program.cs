using System;

namespace SinifveNesneKavrami01
{
    class Program
    {
        static void Main(string[] args)
        {
            // People sınıfı üzerinden bir nesne oluşturuluyor
            // Oluşturulmuş olan bu nesneye 'people' adı veriliyor
            // Constructor (Yapıcı) Method oluşturulurken değer ataması yapılıyor.
            People people = new People(1,"Nisa", "Un", 9);

            // Constructor (Yapıcı) Method oluşturulurken atanan değer ekrana yazdırılıyor.
            Console.WriteLine(people.Name);

            Console.ReadKey();
        }
    }
}
