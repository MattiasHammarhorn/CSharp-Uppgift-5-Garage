namespace GarageExercise.Entities
{
    public class Bus : Vehicle
    {
        private int numberOfSeats;

        public int NumberOfSeats { get => numberOfSeats; set => numberOfSeats = value; }

        public Bus(int registrationNumber, string color, int amountOfWheels, int payload, string model, string make, int numberOfSeats) : base(registrationNumber, color, amountOfWheels, payload, model, make)
        {
            NumberOfSeats = numberOfSeats;
        }
    }
}
