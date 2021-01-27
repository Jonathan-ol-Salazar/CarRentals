using DomainLayer;
using DomainLayer.Customers;
using DomainLayer.Vehicles;
using InfrastructureLayer.Repositories;
using System.Collections.Generic;

namespace CarRentals.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        // View object
        IMainView _mainView;
        IVehicleRepository _vehicleService;
        ICustomerRepository _customerService;

        public MainPresenter(IVehicleRepository vehicleService, ICustomerRepository customerService)
        {
            //_mainView = mainView;
            _vehicleService = vehicleService;
            _customerService = customerService;   
        }

        public void AddView(IMainView mainView)
        {
            _mainView = mainView;
        }


        public IEnumerable<Vehicle> GetAllVehicles()
        {            
            return _vehicleService.GetAll();
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerService.GetAll();
        }

        public IMainView GetMainView()
        {
            return _mainView;
        }

    }
}
