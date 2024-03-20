namespace Garage.Entities
{
    public class Airplane : Vehicle
    {
        private int numberOfEngines;

        public int NumberOfEngines { get => numberOfEngines; set => numberOfEngines = value; }

        public Airplane(int registrationNumber, string color, int amountOfWheels, int payload, string model, string make, int numberOfEngines) : base(registrationNumber, color, amountOfWheels, payload, model, make)
        {
            NumberOfEngines = numberOfEngines;
        }
    }
}
