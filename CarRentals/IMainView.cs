using CarRentals.Presenters;
using DomainLayer.Customers;
using DomainLayer.Rented;
using DomainLayer.Vehicles;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarRentals
{
    public interface IMainView
    {
        void SetPresenter(IMainPresenter mainPresenter);

        IEnumerable<Vehicle> FleetList { get; set; }
        IEnumerable<Customer> CustomerList { get; set; }
        IEnumerable<Rented> RentalReportList { get; set; }
        IEnumerable<Vehicle> RentalSearchList { get; set; }
        
        Vehicle VehicleSearch { get; set; }

        string Rego { get; set; }
        string Make { get; set; }
        string Model { get; set; }
        string Class{ get; set; }
        string Year { get; set; }
        string Transmission { get; set; }
        string Fuel{ get; set; }
        int Seats { get; set; }
        bool Sunroof { get; set; }
        bool GPS { get; set; }
        string Colour { get; set; }
        double DailyRate { get; set; }
        Vehicle SelectedVehicle { get; }

        int CustomerID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string DOB { get; set; }
        string Gender { get; set; }
        string Title { get; set; }
        Customer SelectedCustomer { get; }

        int RentedCustomerID { get; set; }
        string RentedRego { get; set; }
        double RentedDailyRate { get; set; }
        Rented SelectedRented { get; }

        string Query { get; set; }
        bool isQuery { get; set; }

        Vehicle SelectedVehicleResult { get; }

    }



}