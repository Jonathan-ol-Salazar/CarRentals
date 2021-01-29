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
            UpdateReportListView();
        }

        public void UpdateFleetListView()
        {
            _mainView.FleetList = GetAllVehicles();
        }

        public void UpdateCustomerListView()
        {
            _mainView.CustomerList = GetAllCustomers();            
        }

        public void UpdateReportListView()
        {
            _mainView.ReportList = GetAllRented();

        }

        public IEnumerable<Vehicle> GetAllRented()
        {
            return _vehicleService.GetRented().ToList();
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
                ClassType = (ClassType)Enum.Parse(typeof(ClassType), _mainView.Class, true),
                Year = _mainView.Year,
                TransmissionType = (TransmissionType)Enum.Parse(typeof(TransmissionType), _mainView.Transmission, true),
                FuelType = (FuelType)Enum.Parse(typeof(FuelType), _mainView.Fuel, true),
                Seats = _mainView.Seats,
                Sunroof = _mainView.Sunroof,
                GPS = _mainView.GPS,
                Colour = _mainView.Colour,
                DailyRate = _mainView.DailyRate,
                IsRented = true
                
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



        public void AddCustomer()
        {
            Customer customer = new Customer
            {
                //CustomerID = _mainView.CustomerID,
                FirstName = _mainView.FirstName,
                LastName = _mainView.LastName,
                DOB = _mainView.DOB,
                GenderType = (GenderType)Enum.Parse(typeof(GenderType), _mainView.Gender, true),
                Title = _mainView.Title
            };

            _customerService.Add(customer);
            UpdateCustomerListView();
        }

        public void DeleteCustomer()
        {
            _customerService.Delete(_mainView.SelectedCustomer);
            UpdateCustomerListView();
        }

        public void UpdateCustomer()
        {
            Customer customer = _customerService.GetById(_mainView.CustomerID);
            customer.FirstName = _mainView.FirstName;
            customer.LastName = _mainView.LastName;
            customer.DOB = _mainView.DOB;
            customer.GenderType = (GenderType)Enum.Parse(typeof(GenderType), _mainView.Gender, true);
            customer.Title = _mainView.Title;

            _customerService.Update(customer);
            UpdateCustomerListView();
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

        public void RefreshCustomerForm()
        {
            Customer customer = _mainView.SelectedCustomer;
            _mainView.CustomerID = customer.CustomerID;
            _mainView.FirstName = customer.FirstName;
            _mainView.LastName = customer.LastName;
            _mainView.DOB = customer.DOB;
            _mainView.Gender = customer.GenderType.ToString();
            _mainView.Title = customer.Title;
        }
    }
}
