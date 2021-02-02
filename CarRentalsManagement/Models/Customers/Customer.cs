namespace DomainLayer.Customers
{
    public class Customer : ICustomer
    {
        public Customer()
        {

        }

        public Customer(int customerID, TitleType titleType, string firstName, string
            lastName, GenderType genderType, string dob)
        {
            CustomerID = customerID;
            TitleType = titleType;
            FirstName = firstName;
            LastName = lastName;
            GenderType = genderType;
            DOB = dob;
        }


        public int CustomerID { get; set; }
        public TitleType TitleType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public GenderType GenderType { get; set; }
        public bool IsRenting { get; set; }
    }

    public enum TitleType
    {
        Mr,
        Mrs,
        Miss,
        Dr

    }
    public enum GenderType
    {
        Male,
        Female
    }

}
