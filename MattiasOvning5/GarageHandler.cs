using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattiasOvning5
{
    public class GarageHandler
    {

        private Garage<Vehicle> garage;

        public GarageHandler()
        {
            garage = new Garage<Vehicle>(6);
        }

        public void SearchVehicle(string search)
        {
            var result = garage.Where(v => v.RegNum == search);

            foreach(var v in result)
            {
                Console.WriteLine($"Registration number: {v.RegNum}. Color: {v.Color}. Number of wheels: {v.TotalWheels}.");
            }
        }

        public Vehicle[] GetVehicle()
        {
            return garage.ToArray();
        }
    }
}
