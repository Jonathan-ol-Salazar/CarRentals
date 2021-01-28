using DomainLayer.Customers;
using DomainLayer.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CarRentals.Presenters
{
    public interface IMainPresenter
    {
        MainView GetMainView();
        IEnumerable<Vehicle> GetAllVehicles();
        IEnumerable<Customer> GetAllCustomers();
        void SaveNewVehicle();
        void DeleteVehicle();
        void UpdateVehicle();
        void RefreshVehicleForm();
    }
}
