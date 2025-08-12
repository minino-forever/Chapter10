using System.Security.Cryptography;

namespace FunWithGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UseGenericList();

            UseGenericStack();

            UseGenericQueue();

            UseSortedSet();

            UseDictionary();
        }

        static void UseGenericList()
        {
            Console.WriteLine("-> Use Generic List");

            List<Person> people = new List<Person>()
            {
                new Person {FirstName = "Homer", LastName = "Simpson", Age = 50},
                new Person {FirstName = "Marge", LastName = "Simpson", Age = 48},
                new Person {FirstName = "lisa", LastName = "Simpson", Age = 9},
                new Person {FirstName = "Bart", LastName = "Simpson", Age = 8}
            };

            Console.WriteLine($"Items in list: {people.Count}");

            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\nInserting new person.");

            people.Insert(4, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });

            Console.WriteLine($"Items int list: {people.Count}");

            Person[] arrayOfPeople = people.ToArray();

            foreach (Person p in arrayOfPeople)
            {
                Console.WriteLine($"First Names: {p.FirstName}");
            }
        }

        static void UseGenericStack()
        {
            Console.WriteLine("\n-> Use Generic Stack");

            Stack<Person> stackOfPerson = new();

            stackOfPerson.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 50 });
            stackOfPerson.Push(new Person { FirstName = "Marge", LastName = "Simpson", Age = 48 });
            stackOfPerson.Push(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

            Console.WriteLine($"First person is: {stackOfPerson.Peek()}");

            Console.WriteLine($"Popped off: {stackOfPerson.Pop()}");

            Console.WriteLine($"\nFirst person is: {stackOfPerson.Peek()}");

            Console.WriteLine($"Popped off: {stackOfPerson.Pop()}");

            Console.WriteLine($"\nFirst person is: {stackOfPerson.Peek()}");

            Console.WriteLine($"Popped off: {stackOfPerson.Pop()}");

            try
            {
                Console.WriteLine($"\nFirst person is: {stackOfPerson.Peek()}");

                Console.WriteLine($"\nFirst person is: {stackOfPerson.Peek()}");
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine($"\nError! {ex.Message}");
            }
        }

        static void UseGenericQueue()
        {
            Console.WriteLine("\n-> Use Generic Queue");

            Queue<Person> peopleQ = new();

            peopleQ.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 50 });
            peopleQ.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 49 });
            peopleQ.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

            Console.WriteLine($"{peopleQ.Peek().FirstName} is first in line!");

            GetCoffee(peopleQ.Dequeue());

            GetCoffee(peopleQ.Dequeue());

            GetCoffee(peopleQ.Dequeue());

            try
            {
                GetCoffee(peopleQ.Dequeue());
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine($"Error! {e.Message}");
            }

            static void GetCoffee(Person p)
            {
                Console.WriteLine($"{p.FirstName}");
            }
        }

        static void UseSortedSet()
        {
            Console.WriteLine("\n-> Use Sorted set");

            SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
            {
                new Person{FirstName = "Homer", LastName = "Simpson", Age = 47},
                new Person{FirstName = "Marge", LastName = "Simpson", Age = 45},
                new Person{FirstName = "Lisa", LastName = "Simpson", Age = 10},
                new Person{FirstName = "Bart", LastName = "Simpson", Age = 9}
            };

            foreach (Person p in setOfPeople)
            {
                Console.WriteLine(p);
            }

            setOfPeople.Add(new Person { FirstName = "Saku", LastName = "Jones", Age = 11 });
            setOfPeople.Add(new Person { FirstName = "Mikko", LastName = "Jones", Age = 33 });

            foreach (Person p in setOfPeople)
            {
                Console.WriteLine(p);
            }
        }

        static void UseDictionary()
        {
            Console.WriteLine("\n-> Use Dictionary");

            Dictionary<string, Person> peopleA = new Dictionary<string, Person>();

            peopleA.Add("Homer", new Person { FirstName = "Homer", LastName = "Simpson", Age = 40 });
            peopleA.Add("Marge", new Person { FirstName = "Marge", LastName = "Simpson", Age = 35 });
            peopleA.Add("Lisa", new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

            Person homer = peopleA["Homer"];

            Person lisa = peopleA["Lisa"];

            Console.WriteLine($"People with key 'Homer': {homer}");

            Console.WriteLine($"People with key 'Lisa': {lisa}");

            Console.WriteLine("\nInitilization dictionary");

            Dictionary<string, Person> peopleB = new Dictionary<string, Person>()
            {
                {"Homer", new Person {FirstName = "Homer", LastName = "Simson", Age = 47} },
                {"Marge", new Person {FirstName = "Marge", LastName = "Simson", Age = 45} },
                {"Lisa", new Person {FirstName = "Lisa", LastName = "Simson", Age = 9} }
            };

            Person marge = peopleB["Marge"];

            Console.WriteLine($"People with key 'Marge': {marge}");

            Console.WriteLine("\nDictionary Key-Value");

            Dictionary<string, Person> peopleC = new Dictionary<string, Person>()
            {
                ["pHomer"] = new Person { FirstName = "Homer", LastName = "Simpson", Age = 45},
                ["pMarge"] = new Person { FirstName = "Marge", LastName = "Simpson", Age = 43},
                ["pLisa"] = new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9}
            };

            Person personHomer = peopleC["pHomer"];

            Console.WriteLine($"People with key 'pHomer': {personHomer}");
        }
    }
}
