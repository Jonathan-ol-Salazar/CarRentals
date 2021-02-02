using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Vehicles
{
    public class Vehicle : IVehicle
    {
        public Vehicle()
        {

        }       

        public Vehicle(string rego, ClassType classType, string make,
            string model, string year, int seats, TransmissionType transmissionType,
            FuelType fuelType, bool gps, bool sunroof, double dailyRate, string colour)
        {
            Rego = rego;
            ClassType = classType;
            Make = make;
            Model = model;
            Year = year;
            Seats = seats;
            TransmissionType = transmissionType;
            FuelType = fuelType;
            GPS = gps;
            Sunroof = sunroof;
            DailyRate = dailyRate;
            Colour = colour;
        }

        [Key]
        public string Rego { get; set; }
        public ClassType ClassType { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public int Seats { get; set; }
        public TransmissionType TransmissionType { get; set; }
        public FuelType FuelType { get; set; }
        public bool GPS { get; set; }
        public bool Sunroof { get; set; }
        public double DailyRate { get; set; }
        public string Colour { get; set; }

        public bool IsRented { get; set; }
    }
    public enum ClassType
    {
        Ecomony,
        Family,
        Luxury,
        Commercial
    }

    public enum TransmissionType
    {
        Automatic,
        Manual
    }
    public enum FuelType
    {
        Petrol,
        Diesel
    }
}
