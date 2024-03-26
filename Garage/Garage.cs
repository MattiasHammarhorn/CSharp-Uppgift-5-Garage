using GarageExercise.Entities;
using System.Collections;

namespace GarageExercise
{
    internal class Garage<T> : IEnumerable<T> where T : class
    {
        private T[] items;
        private Vehicle[] vehicles;
        private readonly int parkingSpace;

        public Garage(int parkingSpace)
        {
            items = new T[parkingSpace];
            vehicles = new Vehicle[parkingSpace];
            this.parkingSpace = parkingSpace;
        }

        public Vehicle[] GetAllVehicles()
        {
            return vehicles;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
