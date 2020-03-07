using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Nedir07
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.FullName = "Ünal ÜN";
            student.contact = Contact.BusinessPhone;
            Console.WriteLine(student.contact);
            int contactId = (int)student.contact;
            Console.WriteLine(contactId.ToString());
            Console.ReadKey();
        }
    }

    public class Student
    {
        public string FullName { get; set; }
        public Contact contact { get; set; }
    }

    // Default Value : 0
    public enum Contact
    {
        HomePhone = 1,
        CellPhone = 2,
        BusinessPhone = 3,
    }




}



