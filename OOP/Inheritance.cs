using System;

/*
namespace OOP
{
    class Inheritance
    {
        public static void Main(string[] args)
        {
            // Creating an instance of the Car class
            Car myCar = new Car { Brand = "Toyota", Year = 2022, NumberOfDoors = 4 };
            myCar.Start(); // Output: Toyota vehicle started!
            myCar.Honk();  // Output: Toyota car is honking.
        }
    }

    // Base class
    class Vehicle
    {
        // Private fields
        private string brand;
        private int year;

        // Public properties to access private fields
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 1886) // Validating that the year is not before the invention of cars
                {
                    year = value;
                }
                else
                {
                    Console.WriteLine("Year must be 1886 or later.");
                }
            }
        }

        public void Start()
        {
            Console.WriteLine($"{Brand} vehicle started!");
        }
    }

    // Derived class
    public class Car : Vehicle
    {
        private int numberOfDoors;

        // Property to access numberOfDoors
        public int NumberOfDoors
        {
            get { return numberOfDoors; }
            set
            {
                if (value > 0) // Validate that the car has at least one door
                {
                    numberOfDoors = value;
                }
                else
                {
                    Console.WriteLine("Number of doors must be positive.");
                }
            }
        }

        public void Honk()
        {
            Console.WriteLine($"{Brand} car is honking.");
        }
    }
}
*/
