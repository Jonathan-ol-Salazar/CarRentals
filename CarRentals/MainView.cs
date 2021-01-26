using CarRentals.Presenters;
using InfrastructureLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentals
{
    public partial class MainView : Form, IMainView
    {
        public void ShowMainView()
        {
            this.Show();
        }

        public MainPresenter _mainPresenter; 

        public MainView(MainPresenter mainPresenter )
        {
            InitializeComponent();

            _mainPresenter = mainPresenter;
            _mainPresenter.AddView(this);
            //// Populating DataGridView
            //DataGridView_Fleet.DataSource = vehicleRepository.GetAll().ToList();
            //DataGridView_Customer.DataSource = vehicleRepository.GetAll().ToList();

            DataGridView_Fleet.DataSource = _mainPresenter.GetAllVehicles().ToList();


        }


        private void MainView_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
