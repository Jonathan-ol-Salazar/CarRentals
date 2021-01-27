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

    }



}