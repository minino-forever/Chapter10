using System;
using System.Collections;
using System.Collections.Generic;

namespace IssuesWithNongenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleBoxUnboxOperation();

            Console.WriteLine(Environment.NewLine);

            WorkWithArrayList();

            Console.WriteLine(Environment.NewLine);

            UsePersonCollection();

            UseGenericList();
        }

        static void SimpleBoxUnboxOperation()
        {
            int myInt = 25;

            object boxedInt = myInt;

            //int unboxedInt = (int)boxedInt;

            try
            {
                long unboxedLong = (long)boxedInt;
            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        static void WorkWithArrayList()
        {
            ArrayList myInts = new ArrayList();

            myInts.Add(10);
            myInts.Add(20);
            myInts.Add(35);
            myInts.Add(46);

            int i = (int)myInts[0];

            Console.WriteLine($"Value of your int: {i}");
        }

        static void ArrayListOfRandomObjects()
        {
            ArrayList allMyObjects = new ArrayList();

            allMyObjects.Add(true);
            allMyObjects.Add(new OperatingSystem(PlatformID.MacOSX, new Version(10, 0)));
            allMyObjects.Add(666);
            allMyObjects.Add(3.14);
        }

        static void UsePersonCollection()
        {
            Console.WriteLine("*****Custom Person Collection ***\n");

            PersonCollection myPeople = new PersonCollection();

            myPeople.AddPerson(new Person("Homer", "Simpson", 40));
            myPeople.AddPerson(new Person("Marge", "Simpson", 39));
            myPeople.AddPerson(new Person("Lisa", "Simpson", 9));
            myPeople.AddPerson(new Person("Bart", "Simpson", 7));
            myPeople.AddPerson(new Person("Maggie", "Simpson", 2));

            foreach (Person p in myPeople)
            {
                Console.WriteLine(p);
            }
        }

        static void UseGenericList()
        {
            Console.WriteLine("\n******Fun with Generic****\n");

            List<Person> morePerson = new List<Person>();

            morePerson.Add(new Person("Frank", "Black", 50));

            Console.WriteLine(morePerson[0]);

            List<int> moreInt = new List<int>();

            moreInt.Add(10);
            moreInt.Add(2);
            int sum = moreInt[0] + moreInt[1];
        }
    }
}
