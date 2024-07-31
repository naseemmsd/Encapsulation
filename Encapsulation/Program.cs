using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Person
    {
        private string Name;
        private int Age;

        public void SetName(String Name)
        {
            if (String.IsNullOrEmpty(Name) == true)
            {
                Console.WriteLine("Name is required:");
            }
            else
            {
                this.Name = Name;
            }


        }
        public void GetName()
        {
            if (String.IsNullOrEmpty(this.Name) == true)
            {

            }
            else
            {
                Console.WriteLine("Your name is:" + this.Name);

            }

        }
        public void SetAge(int Age)
        {
            if (Age > 0)
            {
                this.Age = Age;
            }
            else
            {
                Console.WriteLine("Age Should Not be Negative Or Zero");
            }
        }
        public void GetAge()
        {
            if (Age > 0)
            {
                Console.WriteLine("your Age Is:"+this.Age);
            }
         

        }
    }
        class program
        {

            static void Main(string[] args)
            {
                Person p = new Person();
                p.SetName("");
                p.GetName();
                p.SetAge(34);
                p.GetAge();



                Console.ReadLine();
            }
        }
    
}