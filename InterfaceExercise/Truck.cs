using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public string OfficeLocation { get; set; }
        public bool HasTrailer { get; set; }
        public bool HasTireChains { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine( $"This Vehicle is a {Brand} {Model} and has {NumberOfWheels} wheels and {NumberOfDoors} doors. This car was made by {Name} and is located in {OfficeLocation} ");
        }
    }
}

