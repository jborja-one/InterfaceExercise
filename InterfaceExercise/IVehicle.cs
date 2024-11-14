using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
		public int NumberOfWheels { get; set; }
		public int NumberOfDoors { get; set; }
		public string Brand { get; set; }
		public string Model { get; set; }
		public string DisplayDetails();
	}
}