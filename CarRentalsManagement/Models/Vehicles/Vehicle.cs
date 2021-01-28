using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Vehicles
{
    public class Vehicle : IVehicle
    {
        public Vehicle()
        {

        }
        public Vehicle(string rego, ClassType classType, string make, string model, int year)
        {
            Rego = rego;
            ClassType = classType;
            Make = make;
            Model = model;
            Year = year;

            // Default
            NumSeats = 4;
            TransmissionType = TransmissionType.Automatic;
            FuelType = FuelType.Petrol;
            GPS = false;
            SunRoof = false;
            Colour = "Black";


            switch (ClassType)
            {
                case ClassType.Ecomony:
                    TransmissionType = TransmissionType.Automatic;
                    DailyRate = 50.00;
                    break;
                case ClassType.Family:
                    TransmissionType = TransmissionType.Automatic;
                    DailyRate = 80.00;
                    break;
                case ClassType.Luxury:
                    GPS = true;
                    SunRoof = true;
                    DailyRate = 120.00;
                    break;
                case ClassType.Commercial:
                    FuelType = FuelType.Diesel;
                    DailyRate = 130.00;
                    break;

                default:
                    break;
            }
        }

        public Vehicle(string rego, ClassType classType, string make,
            string model, int year, int numSeats, TransmissionType transmissionType,
            FuelType fuelType, bool gps, bool sunRoof, double dailyRate, string colour)
        {
            Rego = rego;
            ClassType = classType;
            Make = make;
            Model = model;
            Year = year;
            NumSeats = numSeats;
            TransmissionType = transmissionType;
            FuelType = fuelType;
            GPS = gps;
            SunRoof = sunRoof;
            DailyRate = dailyRate;
            Colour = colour;
        }

        public string ToCSVString()
        {
            return Rego + "," + ClassType.ToString() + "," + Make + "," + Model + "," + Year.ToString() + "," + NumSeats.ToString() + "," + TransmissionType.ToString() + "," + FuelType.ToString() + "," + GPS.ToString() + "," + SunRoof.ToString() + "," + DailyRate.ToString() + "," + Colour;
        }

        public override string ToString()
        {
            return Rego + Make + Model + Year + ClassType + NumSeats + TransmissionType + FuelType + GPS + SunRoof + Colour + DailyRate;
        }


        [Key]
        public string Rego { get; set; }
        public ClassType ClassType { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int NumSeats { get; set; }
        public TransmissionType TransmissionType { get; set; }
        public FuelType FuelType { get; set; }
        public bool GPS { get; set; }
        public bool SunRoof { get; set; }
        public double DailyRate { get; set; }
        public string Colour { get; set; }

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
