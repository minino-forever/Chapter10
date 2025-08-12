namespace FunWithGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UseGenericList();

            UseGenericStack();

            UseGenericQueue();
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
    }
}
