using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Rented
{
    public class Rented : IRented
    {
        public Rented()
        {

        }
        public Rented(string rego, int customerID, double dailyRate)
        {
            Rego = rego;
            CustomerID = customerID;
            DailyRate = dailyRate;
        }

        [Key]
        public int RentID { get; set; }

        public string Rego { get; set; }
        public int CustomerID { get; set; }
        public double DailyRate { get; set; }
    }
}
