using CarRentals.Presenters;
using DomainLayer;
using InfrastructureLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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


            MainPresenter mainPresenter = new MainPresenter(vehicleRepository, customerRepository);

            //mainView.AddPresenter(mainPresenter);

            Application.Run(new MainView(mainPresenter));
        }
    }
}
