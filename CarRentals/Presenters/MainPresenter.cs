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
            _mainView.FleetList = GetAllVehicles();
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
                //VehicleRego = 
                



            };
        }


    }
}
