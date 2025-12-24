using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            

            // Create a list of Vehicle called vehicles
            
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */
            var carOne = new Car()
            {
                Year = "1990", 
                Model = "Chevy",
                Make = "Caprice", 
                HasTrunk = true
            };

            var motorcycleOne = new Motorcycle()
            {
                Year = "2007",
                Make = "Harley",
                Model = "StreetBob",
                HasSideCart = false
            };

            var motorcycleTwo = new Motorcycle()
            {
                Year = "2025",
                Make = "Ducati", 
                Model = "Streetfighter",
                HasSideCart = false
            };
            var motorcycleThree = new Motorcycle()
            {
                Year = "1959",
                Make = "Triumph",
                Model = "Bonnrville",
                HasSideCart = false
            };
                
            var vehicle = new List<Vehicle>() { carOne, motorcycleOne,  motorcycleTwo, motorcycleThree };

            foreach (var v in vehicle)
            {
                Console.WriteLine($"Make: {v.Make}, Model: {v.Model}, Year: {v.Year} Has cart");
                v.DriveAbstract();
                v.DriveVirtual();
                
            }
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
