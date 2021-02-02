using DomainLayer;
using DomainLayer.Customers;
using DomainLayer.Vehicles;
using InfrastructureLayer.Repositories;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System;
using DomainLayer.Rented;
using ServiceLayer.Services;

namespace CarRentals.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        // View object
        IMainView _mainView;
        IVehicleRepository _vehicleService;
        ICustomerService _customerService;
        IRentedService _rentedService;

        public MainPresenter(IMainView mainView, IVehicleRepository vehicleService, ICustomerService customerService, IRentedService rentedRepository)
        {
            // Set View 

            _mainView = mainView;
            _mainView.SetPresenter(this);

            _vehicleService = vehicleService;
            _customerService = customerService;
            _rentedService = rentedRepository;

            StartUpView();
           
        }

        private void StartUpView()
        {
            UpdateFleetListView();
            UpdateCustomerListView();
            UpdateRentalReportListView();
        }

        public void UpdateFleetListView()
        {
            var data = GetAllVehicles();
            if (data.Count() == 0)
            {
                _mainView.Button_FleetModifyVisible = false;
                _mainView.Button_FleetRemoveVisible = false;
            }
            else
            {
                _mainView.Button_FleetModifyVisible = true;
                _mainView.Button_FleetRemoveVisible = true;
            }
            _mainView.FleetList = data;            
        }

        public void UpdateCustomerListView()
        {
            var data = GetAllCustomers();

            if (data.Count() == 0)
            {
                _mainView.Button_CustomersModifyVisible = false;
                _mainView.Button_CustomersRemoveVisible = false;
            }
            else
            {
                _mainView.Button_CustomersModifyVisible = true;
                _mainView.Button_CustomersRemoveVisible = true;
            }
            _mainView.CustomerList = data;
        }

        public void UpdateRentalReportListView()
        {
            _mainView.RentalReportList = GetRented();

            _mainView.TotalVehiclesRented = "Total Vehicles Rented: " + _mainView.RentalReportList.Count();
            _mainView.TotalDailyRate = "Total Daily Rental Charge: " + _rentedService.TotalDailyRate();
        }

        public void UpdateRentalSearchListView()
        {
            if(_mainView.isQuery == true)
            {
                _mainView.VehicleSearch = GetSearch(_mainView.Query);
            }
            else
            {
                _mainView.RentalSearchList = GetNotRented();
            }
        }


        public IEnumerable<Vehicle> GetAllVehicles()
        {            
            return _vehicleService.GetAll().ToList();
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerService.GetAll().ToList();
        }
        public IEnumerable<Rented> GetRented()
        {
            return _rentedService.GetAll().ToList();
        }

        public Vehicle GetSearch(string query)
        {
            return _vehicleService.GetByRego(query);
        }

        public IEnumerable<Vehicle> GetNotRented()
        {
            return _vehicleService.GetNotRented().ToList();
        }

        public List<string> GetNotRenting()
        {
            return _customerService.GetNotRentingList();
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



        public void AddCustomer()
        {
            Customer customer = new Customer
            {
                FirstName = _mainView.FirstName,
                LastName = _mainView.LastName,
                DOB = _mainView.DOB,
                GenderType = (GenderType)Enum.Parse(typeof(GenderType), _mainView.Gender, true),
                TitleType = (TitleType)Enum.Parse(typeof(TitleType), _mainView.Title, true),
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
            Customer customer = _customerService.GetById(_mainView.SelectedCustomer.CustomerID);
            customer.FirstName = _mainView.FirstName;
            customer.LastName = _mainView.LastName;
            customer.DOB = _mainView.DOB;
            customer.GenderType = (GenderType)Enum.Parse(typeof(GenderType), _mainView.Gender, true);
            customer.TitleType = (TitleType)Enum.Parse(typeof(TitleType), _mainView.Title, true);

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
            _mainView.FirstName = customer.FirstName;
            _mainView.LastName = customer.LastName;
            _mainView.DOB = customer.DOB;
            _mainView.Gender = customer.GenderType.ToString();
            _mainView.Title = customer.TitleType.ToString();
        }

        public void AddRental()
        {
            Rented rented = new Rented
            {
                CustomerID = _mainView.RentedCustomerID,
                Rego = _mainView.SelectedVehicleResult.Rego,
                DailyRate = _mainView.SelectedVehicleResult.DailyRate
            };

            _rentedService.Add(rented);

            Customer customer = _customerService.GetById(rented.CustomerID);
            customer.IsRenting = true;
            _customerService.Update(customer);

            Vehicle vehicle = _vehicleService.GetByRego(rented.Rego);
            vehicle.IsRented = true;
            _vehicleService.Update(vehicle);

            UpdateRentalSearchListView();
        }

        public void DeleteRental()
        {
            Rented rented = _mainView.SelectedRented;

            Customer customer = _customerService.GetById(rented.CustomerID);
            customer.IsRenting = false;
            _customerService.Update(customer);

            Vehicle vehicle = _vehicleService.GetByRego(rented.Rego);
            vehicle.IsRented = false;
            _vehicleService.Update(vehicle);

            _rentedService.Delete(rented);

            UpdateRentalReportListView();
        }

        public bool RegoExists()
        {
            return _vehicleService.GetByRego(_mainView.Rego) != null;
        }

    }
}
