namespace DomainLayer.Customers
{
    public class Customer : ICustomer
    {
        // Globals
        private string customerFile = @"CarRentals\ProjectDocuments\customer.csv";


        public Customer()
        {

        }

        public Customer(int customerID, string title, string firstName, string
            lastName, GenderType genderType, string dob)
        {
            CustomerID = customerID;
            Title = title;
            FirstName = firstName;
            LastName = lastName;
            GenderType = genderType;
            DOB = dob;
        }

        public string ToCSVString()
        {
            return CustomerID.ToString() + ',' + Title + ',' + FirstName + ',' + LastName + ',' + GenderType.ToString() + ',' + DOB;
        }

        public override string ToString()
        {
            return CustomerID.ToString() + Title + FirstName + LastName + GenderType.ToString() + DOB;
        }


        public int CustomerID { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public GenderType GenderType { get; set; }


    }
    public enum GenderType
    {
        Male,
        Female
    }
}
