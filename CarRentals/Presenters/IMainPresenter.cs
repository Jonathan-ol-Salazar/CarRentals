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
        void AddVehicle();
        void DeleteVehicle();
        void UpdateVehicle();
        void RefreshVehicleForm();
        void AddCustomer();
        void DeleteCustomer();
        void UpdateCustomer();
        void RefreshCustomerForm();
        void UpdateFleetListView();
        void UpdateCustomerListView();
        void UpdateReportListView();
        void RentVehicle();
           



    }
}
