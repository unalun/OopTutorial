

using System;

namespace SinifveNesneKavrami01
{





    public class People
    {
        // Constructor (Yapıcı) Method
        // sınıf oluşturulurken çalışan bir method
        // yapıcı method oluşturulurken değerler alınabilir
        public People(int id, string name, string surName, int age)
        {
            Id = id;
            Name = name;
            SurName = surName;
            Age = age;
            
            Console.WriteLine("Constructor bir Method Çalıştı");
        }

        // insan sınıfı özelliklerini burada tanımlayabiliriz.
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }

        // Destructors (Yıkıcı) Method
        // bu method bellekten atılmadan önceki durumda çağrılır  
        ~People()
        {
            Console.WriteLine("Destructors bir Method Çalıştı");
        }

        public People GetById(int id)
        {
            return null;
        }



        // string tipinde değer döndürmeyen ve parametre almayan bir method
        public string WelComeMessage()
        {
            return "Welcome";
        }

        // Overload
        // string tipinde değer döndüren ve parametre alan bir method
        public string WelComeMessage(string name)
        {
            return "Welcome : " + name;
        }

        // Overload
        // string tipinde değer döndüren ve 2 adet parametre alan bir method
        public string WelComeMessage(string name, string surName)
        {
            return name + surName;
        }


        // değer döndürmeyen ve parametre alan bir method
        public void GoodByeMessage(string name)
        {
            Console.WriteLine("Hoşgeldin {0}", name);
        }

        // Overload
        // değer döndürmeyen ve 2 adet parametre alan bir method
        public void GoodByeMessage(string name,string surName)
        {
            Console.WriteLine("Hoşgeldin {0} {1}", name,surName);
        }

    }









}














