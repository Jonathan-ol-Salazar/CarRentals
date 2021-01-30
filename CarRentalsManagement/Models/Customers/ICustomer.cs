namespace DomainLayer.Customers
{
    public interface ICustomer
    {
        int CustomerID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string DOB { get; set; }
        GenderType GenderType { get; set; }
        string Title { get; set; }
        bool IsRenting { get; set; }

        string ToCSVString();
        string ToString();
    }
}