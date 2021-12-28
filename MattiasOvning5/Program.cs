using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattiasOvning5
{
    class Program
    {
        static void Main(string[] args)
        {
            var inGarage = new Garage<Vehicle>(capacity: 6);
            GarageHandler handler = new GarageHandler();
            bool isOn = true;
            while (isOn == true)
            {
                Console.WriteLine("Welcome to Celius' Garage!\n" +
                    "1: Add Vehicle.\n" +
                    "2: Remove Vehicle.\n" +
                    "3: Check garage.\n" +
                    "4: Quit application.\n");

                Console.Write("What would you like to do today? \n\n");
                int index = int.Parse(Console.ReadLine())!;
                switch (index)
                {
                    case 1:
                        Console.WriteLine("What kind of vehicle do you wish to add?\n");
                        Console.Write("1: Add a car.\n" +
                            "2: Add a truck.\n" +
                            "3: Add a bike.\n" +
                            "4: Add an airplane.\n" +
                            "5: Add a boat. \n.");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.Write("How many wheels does this vehicle have: ");
                                int wheelsCar = int.Parse(Console.ReadLine());

                                Console.Write("What color is it?: ");
                                string colorCar = Console.ReadLine();

                                Console.Write("What is it's registration nummer: ");
                                string regnumCar = Console.ReadLine();

                                Car newCar = new Car(wheelsCar, colorCar, regnumCar);
                                inGarage.AddVehicle(newCar);
                                break;

                            case 2:
                                int wheelsBus = 6;
                                Console.Write("What color is it?: ");
                                string colorBus = Console.ReadLine();

                                Console.Write("What is it's registration nummer: ");
                                string regnumBus = Console.ReadLine();

                                Bus newBus = new Bus(wheelsBus, colorBus, regnumBus);
                                inGarage.AddVehicle(newBus);
                                break;

                            case 3:
                                int wheelsBike = 2;
                                Console.Write("What color is it?: ");
                                string colorBike = Console.ReadLine();

                                Console.Write("What is it's registration nummer?");
                                string regnumBike = Console.ReadLine();

                                Bike newBike = new Bike(wheelsBike, colorBike, regnumBike);
                                inGarage.AddVehicle(newBike);
                                break;

                            case 4:
                                int wheelsPlane = 3;
                                Console.Write("What color is it?: ");
                                string colorPlane = Console.ReadLine();

                                Console.Write("What is it's registration nummer?");
                                string regnumPlane = Console.ReadLine();

                                Airplane newPlane = new Airplane(wheelsPlane, colorPlane, regnumPlane);
                                inGarage.AddVehicle(newPlane);
                                break;

                            case 5:
                                int wheelsBoat = 0;
                                Console.Write("What color is it?: ");
                                string colorBoat = Console.ReadLine();

                                Console.Write("What is it's registration number?: ");
                                string regnumBoat = Console.ReadLine();

                                Boat newBoat = new Boat(wheelsBoat, colorBoat, regnumBoat);
                                break;

                            default:
                                Console.WriteLine("Please type one of the corresponding numbers.");
                                break;
                        }
                        break;

                    case 2:
                        var array = inGarage.vehicles;
                        Console.Write("Look for a vehicle.");
                        string find = Console.ReadLine()!;

                        inGarage.RemoveVehicle(find);

                        break;

                    case 3:
                        Console.Write("\n\nSearch for your vehicle by registration number: ");
                        string search = Console.ReadLine();
                        handler.SearchVehicle(search);
                        break;

                    case 4:
                        isOn = false;
                        break;

                    default:
                        Console.WriteLine("Please type one of the corresponding numbers.");
                        break;
                }
            }
        }
    }
}
