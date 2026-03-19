using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {

        public Person()
        {
            Console.WriteLine("Object created");
        }


        private string name;

        public void SetName(string n)
        {
            name = n;
        }

        public string GetName()
        {
            return name;
        }

        ////////////////////


        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
                else
                    Console.WriteLine("Invalid Age");
            }
        }
    }
}
