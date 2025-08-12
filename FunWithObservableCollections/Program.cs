using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
namespace FunWithObservableCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<Person> people = new ObservableCollection<Person>()
            {
                new Person{FirstName = "Peter", LastName = "Murphy", Age = 52},
                new Person{FirstName = "Kevin", LastName = "Key", Age = 48}
            };

            people.CollectionChanged += people_CollectionChanged;

            static void people_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
            {
                //throw new NotImplementedException();

                Console.WriteLine($"Action for this event: {e.Action}");

                if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
                {
                    Console.WriteLine("Here are the OLD items:");

                    foreach (Person p in e.OldItems)
                    {
                        Console.WriteLine(p.ToString());
                    }
                    Console.WriteLine();
                }

                if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
                {
                    Console.WriteLine("Here are the NEW items:");

                    foreach (Person p in e.NewItems)
                    {
                        Console.WriteLine(p.ToString());
                    }
                }
            }

            people.Add(new Person("Fred", "Smith", 32));

            people.RemoveAt(0);
        }

        public enum NotifyCollectionChangedAction
        {
            Add = 0,
            Remove = 1,
            Replace = 2,
            Move = 3,
            Reset = 4,
        }
    }
}
