using DomainLayer;
using InfrastructureLayer.Repositories;
using System.Collections.Generic;

namespace CarRentals.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        // View object
        IMainView _mainView;
        IVehicleRepository _vehicleRepository;
        ICustomerRepository _customerRepository;

        public MainPresenter(IVehicleRepository vehicleRepository, ICustomerRepository customerRepository)
        {
            //_mainView = mainView;
            _vehicleRepository = vehicleRepository;
            _customerRepository = customerRepository;   
        }

        public void AddView(IMainView mainView)
        {
            _mainView = mainView;
        }


        public IEnumerable<Vehicle> GetAllVehicles()
        {            
            return _vehicleRepository.GetAll();
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAll();
        }

        public IMainView GetMainView()
        {
            return _mainView;
        }

    }
}
