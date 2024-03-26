using GarageExercise.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GarageExercise
{
    internal class Manager
    {
        public static Garage<Vehicle> garage = new Garage<Vehicle>(10);

        internal void Run()
        {
            SeedData();

            bool isRunning = true;
            string userInput = string.Empty;

            do
            {
                Console.WriteLine("Welcome to the Garage!");
                Console.WriteLine("1. List all vehicles");
                Console.WriteLine("2. List all vehicle types");
                Console.Write("Your choice: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ListAllVehicles();
                        break;
                    case "2":
                        ListAllVehicleTypes();
                        break;
                    case "3":
                        break;
                    case "0":
                        isRunning = false;
                        break;
                }

            } while (isRunning);
        }

        internal void ListAllVehicles()
        {
            var vehicles = garage.GetAllVehicles();
            //Todo: move logic to a UI class
            for (int i = 0; i < vehicles.Length; i++)
            {
                var vehicle = vehicles[i];
                if(vehicle is not null)
                    Console.WriteLine($"Parking space {i+1}: {vehicle}");
                else
                    Console.WriteLine($"Parking space {i+1}: vacant");
            }
        }

        internal void ListAllVehicleTypes()
        {
            var vehicles = garage.GetAllVehicles();
            int airPlanes, motorCycles, cars, busses, boats;
            airPlanes = motorCycles = cars = busses = boats = 0;
            // Todo: find a less atrocious way of doing this
            // Loop through each vehicle and increment a counter
            // for each type based on what type it is
            for (int i = 0; i < vehicles.Length; i++)
            {
                var vehicle = vehicles[i];
                if (vehicle is not null)
                {
                    switch (vehicle.GetType().Name!)
                    {
                        case "Airplane":
                            airPlanes++;
                            break;
                        case "Motorcycle":
                            motorCycles++;
                            break;
                        case "Car":
                            cars++;
                            break;
                        case "Bus":
                            busses++;
                            break;
                        case "Boat":
                            boats++;
                            break;
                        default:
                            break;
                    }
                }
            }
            Console.WriteLine($"Airplanes parked: {airPlanes}");
            Console.WriteLine($"Motorcycles parked: {motorCycles}");
            Console.WriteLine($"Cars parked: {cars}");
            Console.WriteLine($"Busses parked: {busses}");
            Console.WriteLine($"Boats parked: {boats}");
        }

        internal void SeedData()
        {
            Vehicle vehicle1 = new Airplane("XX-154","White",4,300,"Boeing 747","Boeing",6);
            Vehicle vehicle2 = new Motorcycle("JPG-65", "Black", 2, 5, "Bat Mobile", "Wayne", 6);
            Vehicle vehicle3 = new Car("ZAD-678","Pink",4,50,"M60","Volvo",FuelType.Gasoline);
            Vehicle vehicle4 = new Bus("FF-667","Red",8,150,"M70","SAAB",16);
            Vehicle vehicle5 = new Boat("FX-764","Green",4,500,"Yachtie","YachtMaker",4);
            garage.Add(vehicle1);
            garage.Add(vehicle2);
            garage.Add(vehicle3);
            garage.Add(vehicle4);
            garage.Add(vehicle5);
        }
    }
}
