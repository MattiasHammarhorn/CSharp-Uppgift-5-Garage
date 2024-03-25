namespace GarageExercise.Entities
{
    public class Motorcycle : Vehicle
    {
        private int cylinderVolume;

        public int CylinderVolume { get => cylinderVolume; set => cylinderVolume = value; }

        public Motorcycle(int registrationNumber, string color, int amountOfWheels, int payload, string model, string make, int cylinderVolume) : base(registrationNumber, color, amountOfWheels, payload, model, make)
        {
            CylinderVolume = cylinderVolume;
        }
    }
}
