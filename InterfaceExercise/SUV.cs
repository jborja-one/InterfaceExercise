using System;
namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany
	{
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public string OfficeLocation { get; set; }
        public bool HasBikeRack { get; set; }
        public bool Has4x4 { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"This Vehicle is a {Brand} {Model} and has {NumberOfWheels} wheels and {NumberOfDoors} doors. This car was made by {Name} and is located in {OfficeLocation} ");
        }
    }
}

