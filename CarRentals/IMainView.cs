using CarRentals.Presenters;
using DomainLayer.Customers;
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

        string Rego { get; set; }
        string Make { get; set; }
        string Model { get; set; }
        string Class{ get; set; }
        int Year { get; set; }
        string Transmission { get; set; }
        string Fuel{ get; set; }
        int Seats { get; set; }
        bool Sunroof { get; set; }
        bool GPS { get; set; }
        string Colour { get; set; }
        int DailyRate { get; set; }



    }



}