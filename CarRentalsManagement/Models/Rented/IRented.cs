namespace DomainLayer.Rented
{
    public interface IRented
    {
        int RentID { get; set; }
        string Rego { get; set; }
        int CustomerID { get; set; }
        double DailyRate { get; set; }



    }
}
