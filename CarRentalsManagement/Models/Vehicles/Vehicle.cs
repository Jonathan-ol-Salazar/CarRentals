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
            Seats = 4;
            TransmissionType = TransmissionType.Automatic;
            FuelType = FuelType.Petrol;
            GPS = false;
            Sunroof = false;
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
                    Sunroof = true;
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
            string model, int year, int seats, TransmissionType transmissionType,
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

        public string ToCSVString()
        {
            return Rego + "," + ClassType.ToString() + "," + Make + "," + Model + "," + Year.ToString() + "," + Seats.ToString() + "," + TransmissionType.ToString() + "," + FuelType.ToString() + "," + GPS.ToString() + "," + Sunroof.ToString() + "," + DailyRate.ToString() + "," + Colour;
        }

        public override string ToString()
        {
            return Rego + Make + Model + Year + ClassType + Seats + TransmissionType + FuelType + GPS + Sunroof + Colour + DailyRate;
        }


        [Key]
        public string Rego { get; set; }
        public ClassType ClassType { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Seats { get; set; }
        public TransmissionType TransmissionType { get; set; }
        public FuelType FuelType { get; set; }
        public bool GPS { get; set; }
        public bool Sunroof { get; set; }
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
