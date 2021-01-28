using DomainLayer;
using DomainLayer.Customers;
using DomainLayer.Vehicles;
using InfrastructureLayer.Repositories;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

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
                //ClassType = _mainView.Class,
                Year = _mainView.Year,
                //TransmissionType = 
                //FuelType =
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
