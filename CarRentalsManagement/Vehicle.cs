using System;
using System.Collections.Generic;

namespace CarRentalsManagement
{
    public class Vehicle
    {

        public Vehicle( string vehicleRego, VehicleClass vehicleClass, string make, string model, int year)
        {


        }
        public Vehicle(string vehicleRego, VehicleClass vehicleClass, string make,
            string model, int year, int numSeats, TransmissionType transmissionType,
            FuelType fuelType, bool GPS, bool sunRoof, double dailyRate, string colour)
        {

        }

        public string ToCSVString()
        {
            return "";
        }

        public override string ToString()
        {
            return "";
        }

        public List<string> GetAttributeList()
        {
            return new List<string>();
        }

    }
    public enum VehicleClass
    {

    }

    public enum TransmissionType
    {

    }
    public enum FuelType
    {

    }
}
