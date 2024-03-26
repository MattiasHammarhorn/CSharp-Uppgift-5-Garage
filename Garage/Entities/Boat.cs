namespace GarageExercise.Entities
{
    public class Boat : Vehicle
    {
        private int length;

        public int Length { get => length; set => length = value; }

        public Boat(string registrationNumber, string color, int amountOfWheels, int payload, string model, string make, int length) : base(registrationNumber, color, amountOfWheels, payload, model, make)
        {
            Length = length;
        }
    }
}
