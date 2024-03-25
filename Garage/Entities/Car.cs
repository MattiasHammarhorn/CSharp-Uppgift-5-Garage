namespace GarageExercise.Entities
{
    public class Car : Vehicle
    {
        private FuelType fuelType;
        
        public FuelType FuelType { get => fuelType; set => fuelType = value; }

        public Car(int registrationNumber, string color, int amountOfWheels, int payload, string model, string make, FuelType fuelType) : base(registrationNumber, color, amountOfWheels, payload, model, make)
        {
            FuelType = fuelType;
        }
    }

    public enum FuelType
    {
        Gasoline,
        Diesel
    }
}
