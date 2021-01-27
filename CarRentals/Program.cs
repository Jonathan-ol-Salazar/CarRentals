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


            Context context = new Context();
            VehicleRepository vehicleRepository = new VehicleRepository(context);
            CustomerRepository customerRepository = new CustomerRepository(context);
            VehicleService vehicleService = new VehicleService(vehicleRepository);
            CustomerService customerService = new CustomerService(customerRepository);

            // Make conext, repo, service
            // Make view
            // Make presenter with view and repo


            MainPresenter mainPresenter = new MainPresenter(vehicleRepository, customerRepository);

            //mainView.AddPresenter(mainPresenter);

            Application.Run(new MainView(mainPresenter));
        }
    }
}
