using GarageExercise.Entities;
using System.Collections;

namespace GarageExercise
{
    internal class Garage<T> : IEnumerable<T> where T : class
    {
        private List<T> items;
        private Vehicle[] vehicles;
        private int parkingSpace;

        public Garage(int parkingSpace)
        {
            vehicles = new Vehicle[parkingSpace];
            this.parkingSpace = parkingSpace;
        }

        // Loop through array to find an index which isn't null
        // and store the vehicle there
        public virtual void Add<T>(T item)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    // Todo: handle possible null exception
                    vehicles[i] = item as Vehicle;
                    break;
                }
            }
        }

        public virtual void Remove(Vehicle vehicle)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == vehicle)
                    // Todo: handle possible null exception
                    vehicles[i] = null;
            }
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
