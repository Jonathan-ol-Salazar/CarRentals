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

        public void AddVehicle()
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


        public void DeleteVehicle()
        {
            _vehicleService.Delete(_mainView.SelectedVehicle);
            UpdateFleetListView();
        }

        public void UpdateVehicle()
        {
            Vehicle vehicle = _vehicleService.GetByRego(_mainView.Rego);
            vehicle.Make = _mainView.Make;
            vehicle.Model = _mainView.Model;
            vehicle.ClassType = (ClassType)Enum.Parse(typeof(ClassType), _mainView.Class, true);
            vehicle.Year = _mainView.Year;
            vehicle.TransmissionType = (TransmissionType)Enum.Parse(typeof(TransmissionType), _mainView.Transmission, true);
            vehicle.FuelType = (FuelType)Enum.Parse(typeof(FuelType), _mainView.Fuel, true);
            vehicle.Seats = _mainView.Seats;
            vehicle.Sunroof = _mainView.Sunroof;
            vehicle.GPS = _mainView.GPS;
            vehicle.Colour = _mainView.Colour;
            vehicle.DailyRate = _mainView.DailyRate;

            _vehicleService.Update(vehicle);

            UpdateFleetListView();
        }

        public void RefreshVehicleForm()
        {
            Vehicle vehicle = _mainView.SelectedVehicle;
            _mainView.Rego = vehicle.Rego;
            _mainView.Make = vehicle.Make;
            _mainView.Model = vehicle.Model;
            _mainView.Class = vehicle.ClassType.ToString();
            _mainView.Year = vehicle.Year;
            _mainView.Transmission = vehicle.TransmissionType.ToString();
            _mainView.Fuel = vehicle.FuelType.ToString();
            _mainView.Seats = vehicle.Seats;
            _mainView.Sunroof = vehicle.Sunroof;
            _mainView.GPS = vehicle.GPS;
            _mainView.Colour = vehicle.Colour;
            _mainView.DailyRate = vehicle.DailyRate;

        }
    }
}
