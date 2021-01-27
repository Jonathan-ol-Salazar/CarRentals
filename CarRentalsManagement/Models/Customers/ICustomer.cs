namespace DomainLayer.Customers
{
    public interface ICustomer
    {
        int CustomerID { get; set; }
        string DOB { get; set; }
        string FirstName { get; set; }
        Gender Gender { get; set; }
        string LastName { get; set; }
        string Title { get; set; }

        string ToCSVString();
        string ToString();
    }
}