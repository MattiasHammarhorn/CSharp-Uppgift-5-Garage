using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Entities
{
    public class Vehicle
    {
        private int registrationNumber;
        private string color;
        private int amountOfWheels;
        private int payload;
        private string model;
        private string make;

        public int RegistrationNumber { get => registrationNumber; set => registrationNumber = value; }
        public string Color { get => color; set => color = value; }
        public int AmountOfWheels { get => amountOfWheels; set => amountOfWheels = value; }
        public int Payload { get => payload; set => payload = value; }
        public string Model { get => model; set => model = value; }
        public string Make { get => make; set => make = value; }

        public Vehicle(int registrationNumber, string color, int amountOfWheels, int payload, string model, string make)
        {
            RegistrationNumber = registrationNumber;
            Color = color;
            AmountOfWheels = amountOfWheels;
            Payload = payload;
            Model = model;
            Make = make;
        }
    }
}
