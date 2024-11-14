using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany DONE

            //Create 3 classes called Car , Truck , & SUV DONE

            //In your IVehicle: DONE

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: DONE

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes DONE

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            Car car = new Car()
            {
                NumberOfWheels = 4,
                NumberOfDoors = 4,
                Brand = "Ford",
                Model = "Focus",
                OfficeLocation = "Dearborn, MI",
                IsItARaceCar = false,
                TypeOfTransmission = "Automatic"
            };

            Truck truck = new Truck()
            {
                NumberOfWheels = 18,
                NumberOfDoors = 3,
                Brand = "Volvo",
                Model = "Volvo VHD",
                Name = "The Volvo Group",
                OfficeLocation = "Gothenburg, Sweden",
                HasTrailer = true,
                HasTireChains = false
            };

            SUV suv = new SUV()
            {
                NumberOfWheels = 4,
                NumberOfDoors = 4,
                Brand = "Jeep",
                Model = "Cherokee",
                Name = "Fiat Chrysler Automobiles",
                OfficeLocation = "Auburn Hills, Michigan",
                HasBikeRack = true,
                Has4x4 = true
            };

            car.DisplayDetails();
            truck.DisplayDetails();
            suv.DisplayDetails();
        //Option for displaying values: 
        //Create a stubbed out method called DisplayDetails in your IVehicle interface.
        //Implement the stubbed out method in the derived classes.
        //In the scope of them method, use string interpolation to display property values.
        //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
