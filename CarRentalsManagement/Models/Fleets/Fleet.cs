using DomainLayer.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Fleets
{
    public class Fleet
    {  
        // Globals
        List<Vehicle> vehicles;
        Dictionary<string, int> rentals;
        //string fleetFile;
        string rentalFile;
        private string fleetFile = @"CarRentals\ProjectDocuments\fleet.csv";


        public Fleet()
        {

        }

        public bool AddVehicle(Vehicle vehicle)
        {
            return false;
        }
        public bool RemoveVehicle(Vehicle vehicle)
        {
            return false;
        }
        public bool RemoveVehicle(string vehicleRego)
        { 
            return false;
        }
        public List<Vehicle> GetFleet()
        {
            return new List<Vehicle>();
        }
        public List<Vehicle> GetFleet(bool rented)
        {
            return new List<Vehicle>();
        }

        public bool IsRented(string vehicleRego)
        {
            return false;
        }

        public bool IsRenting(int customerID)
        {
            return false;
        }

        public int RentedBy(string vehicleRego)
        {
            return 1;
        }

        public bool RentCar(string vehicleRego, int customerID)
        {
            return false;
        }

        public int ReturnCar(string vehicleRego)
        {
            return 1;
        }

        public void SaveToFile()
        {

        }

        public void LoadFromFile()
        {

        }
    }
}
