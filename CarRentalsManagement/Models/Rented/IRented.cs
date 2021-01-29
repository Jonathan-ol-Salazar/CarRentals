namespace DomainLayer.Rented
{
    public interface IRented
    {
        int RentID { get; set; }
        string Rego { get; set; }
        string CustomerID { get; set; }
        double DailyRate { get; set; }



    }
}
