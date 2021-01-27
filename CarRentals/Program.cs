using CarRentals.Presenters;
using InfrastructureLayer.Repositories;
using ServiceLayer.Services;
using System;
using System.Windows.Forms;

namespace CarRentals
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Setup Context -> Repository -> Service
            Context context = new Context();
            VehicleRepository vehicleRepository = new VehicleRepository(context);
            CustomerRepository customerRepository = new CustomerRepository(context);
            VehicleService vehicleService = new VehicleService(vehicleRepository);
            CustomerService customerService = new CustomerService(customerRepository);

            // Initialize View
            MainView mainView = new MainView();

            // Initialize Presenter
            MainPresenter mainPresenter = new MainPresenter(mainView, vehicleService, customerService);

            Application.Run(mainView);
        }
    }
}
