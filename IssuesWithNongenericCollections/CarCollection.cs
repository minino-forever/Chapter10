using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuesWithNongenericCollections
{
    internal class CarCollection : IEnumerable
    {
        private ArrayList arCars = new ArrayList();

        public Car GetCar(int pos) => (Car)arCars[pos];

        public void AddCar(Car c)
        {
            arCars.Add(c);
        }

        public void ClearCars()
        {
            arCars.Clear();
        }

        public int Count => arCars.Count;

        public IEnumerator GetEnumerator() => arCars.GetEnumerator();
    }
}
