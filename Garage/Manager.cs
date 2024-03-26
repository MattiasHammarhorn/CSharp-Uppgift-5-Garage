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
        internal void Run()
        {
            Garage<Vehicle> garage = new Garage<Vehicle>(5);

            bool isRunning = true;
            string userInput = string.Empty;

            do
            {
                Console.WriteLine("Welcome to the Garage!");
                Console.WriteLine("1. List all vehicles in the garage");
                Console.Write("Your choice: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        var vehicles = garage.GetAllVehicles();
                        for (int i = 0; i < vehicles.Length; i++)
                        {
                            var vehicle = vehicles[i];
                            Console.WriteLine($"Vehicle {vehicle} at parking space {i+1}");
                        }
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "0":
                        isRunning = false;
                        break;
                }

            } while (isRunning);
        }

        internal void SeedData(Garage<Vehicle> garage)
        {
            Vehicle vehicle1 = new Airplane("XX-154","White",4,300,"Boeing 747","Boeing",6);
            Vehicle vehicle2 = new Motorcycle("JPG-65", "Black", 2, 5, "Bat Mobile", "Wayne", 6);
            Vehicle vehicle3 = new Car("ZAD-678","Pink",4,50,"M60","Volvo",FuelType.Gasoline);
            Vehicle vehicle4 = new Bus("FF-667","Red",8,150,"M70","SAAB",16);
            Vehicle vehicle5 = new Boat("FX-764","Green",4,500,"Yachtie","YachtMaker",4);

        }
    }
}
