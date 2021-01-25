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

            //IMainPresenter mainPresenter = new IMainPresenter();

            //IMainView mainView = MainPresenter.GetMainView();

            Context context = new Context();


            VehicleRepository vehicleRepository = new VehicleRepository(context);

            Vehicle vehicle = new Vehicle
            {
                VehicleRego = "Yeet",
                Make = "Ferrari",
                Model = "458 Pista"
            };

            //vehicleRepository.Add(vehicle);



            Application.Run(new MainView(vehicleRepository));
        }
    }
}
