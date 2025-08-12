using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuesWithNongenericCollections
{
    internal class Car
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public Car() { }

        public Car(string firstName, string lastName, int age)
        {
            Age = age;

            Name = firstName;

            Model = lastName;
        }

        public override string ToString()
        {
            return $"Name: {Name} {Model}, Age: {Age}";
        }
    }
}
