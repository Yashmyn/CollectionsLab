using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLab
{
    class Person
    {
        string firstName;
        string lastName;

        public Person()
        {

        }

        public Person(string _firstName, string _lastName)
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
        }

        public void Print()
        {
            Console.WriteLine(this.firstName + " " + this.lastName);
        }
    }
}
