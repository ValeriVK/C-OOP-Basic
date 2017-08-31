using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Person
    {
        private string name;
        private int age;

        public Person() : this("No name", 1)
        { } 
        public Person(int age) : this("No name", age)
        {
            this.age = age;
        }
        public Person( string name, int age)
        {
            this.name = name;
            this.age = age; 
        }

        public int Age { get { return this.age; } }
        public string Name { get { return this.name; } }
    }
}
