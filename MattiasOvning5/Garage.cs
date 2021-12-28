using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;


namespace MattiasOvning5
{
    class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        public T[] vehicles;

        private int count;
        private int capacity;

        public Garage(int capacity)
        {
            vehicles = new T[capacity +1];
        }

        public void AddVehicle(T newVehicle)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if(vehicles[i] == default(T))
                {
                    vehicles[i] = newVehicle;
                    count++;
                    Console.WriteLine($"\n{newVehicle.TotalWheels} {newVehicle.Color} {newVehicle.RegNum}\n");
                    Console.WriteLine($"{vehicles[i].RegNum}\n");
                    break;
                }
            }
        }

        public void RemoveVehicle(T removeVehicle)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == removeVehicle)
                {
                    vehicles[i] = default(T)!;
                    count--;
                    Console.WriteLine("The vehicle has now been removed from the garage.");
                    break;
                }
                else if (vehicles[i] == null)
                {
                    Console.WriteLine("This vehicle doesn't exist in this garage.");
                }
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            foreach (var items in vehicles)
            {
                if (items != null)              
                yield return items;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}