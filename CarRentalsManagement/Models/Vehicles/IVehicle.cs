namespace DomainLayer.Vehicles
{
    public interface IVehicle
    {
        string Colour { get; set; }
        double DailyRate { get; set; }
        FuelType FuelType { get; set; }
        bool GPS { get; set; }
        string Make { get; set; }
        string Model { get; set; }
        int NumSeats { get; set; }
        bool SunRoof { get; set; }
        TransmissionType TransmissionType { get; set; }
        ClassType ClassType { get; set; }
        string Rego { get; set; }
        int Year { get; set; }

        string ToCSVString();
        string ToString();
    }
}