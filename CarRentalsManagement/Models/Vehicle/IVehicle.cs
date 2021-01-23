namespace CarRentalsManagement
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
        VehicleClass VehicleClass { get; set; }
        string VehicleRego { get; set; }
        int Year { get; set; }

        string ToCSVString();
        string ToString();
    }
}