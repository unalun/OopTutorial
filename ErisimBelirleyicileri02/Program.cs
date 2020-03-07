using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirleyicileri02
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private void PrivateMethod()
        {
            //Bulunduğu sınıf içerisinde çağırabilir.
        }

        public void PublicMethod()
        {
            //Proje içerisinden veya proje dışarısından her yerden erişilebilir.
        }

        internal void InternalMethod()
        {
            //Aynı proje içerisinden çağırılabilir
            // kendi proje içerisinde public, farklı projelerden çağırılmak instendiğin de private özellikleri taşır.
        }

        protected void ProtectedMethod()
        {
            //Bir nesne protected olarak tanımlandığında yalnızca bulunduğu sınıf üzerinde
            // oluşturulmuş olan bu sınıfı miras alan ( bu sınıftan türetilmiş) sınıflar üzerinden çağırılabilir.
        }
    }



}
