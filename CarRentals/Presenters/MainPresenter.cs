using DomainLayer;
using DomainLayer.Customers;
using DomainLayer.Vehicles;
using InfrastructureLayer.Repositories;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System;

namespace CarRentals.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        // View object
        IMainView _mainView;
        IVehicleRepository _vehicleService;
        ICustomerRepository _customerService;

        public MainPresenter(IMainView mainView,IVehicleRepository vehicleService, ICustomerRepository customerService)
        {
            // Set View 

            _mainView = mainView;
            _mainView.SetPresenter(this);

            _vehicleService = vehicleService;
            _customerService = customerService;


            StartUpView();
           
        }

        private void StartUpView()
        {
            UpdateFleetListView();
            UpdateCustomerListView();
        }

        private void UpdateFleetListView()
        {
            _mainView.FleetList = GetAllVehicles();
        }

        private void UpdateCustomerListView()
        {
            _mainView.CustomerList = GetAllCustomers();            
        }

        public IEnumerable<Vehicle> GetAllVehicles()
        {            
            return _vehicleService.GetAll().ToList();
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerService.GetAll().ToList();
        }

        public MainView GetMainView()
        {
            return (MainView)_mainView;
        }

        public void SaveNewVehicle()
        {
            Vehicle vehicle = new Vehicle
            {
                Rego = _mainView.Rego,
                Make = _mainView.Make,
                Model = _mainView.Model,
                ClassType = (ClassType) Enum.Parse(typeof(ClassType), _mainView.Class, true),
                Year = _mainView.Year,
                TransmissionType = (TransmissionType)Enum.Parse(typeof(TransmissionType), _mainView.Transmission, true),
                FuelType = (FuelType)Enum.Parse(typeof(FuelType), _mainView.Fuel, true),
                Seats = _mainView.Seats,
                Sunroof = _mainView.Sunroof,
                GPS = _mainView.GPS,
                Colour = _mainView.Colour,
                DailyRate = _mainView.DailyRate

            };

            _vehicleService.Add(vehicle);
            UpdateFleetListView();
        }


    }
}
