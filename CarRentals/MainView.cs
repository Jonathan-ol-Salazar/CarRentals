using CarRentals.Presenters;
using DomainLayer.Customers;
using DomainLayer.Vehicles;
using InfrastructureLayer.Repositories;
using ServiceLayer.Services;
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

        public IMainPresenter _mainPresenter;

        public MainView()
        {
            InitializeComponent();

        }

        public IEnumerable<Vehicle> FleetList
        {
            get { return (IEnumerable<Vehicle>)this.DataGridView_Fleet.DataSource; }
            set { this.DataGridView_Fleet.DataSource = value; }
        }
        public IEnumerable<Customer> CustomerList
        {
            get { return (IEnumerable<Customer>)this.DataGridView_Customers.DataSource; }
            set { this.DataGridView_Customers.DataSource = value; }
        }

        public void SetPresenter(IMainPresenter mainPresenter)
        {
            _mainPresenter = mainPresenter;
        }


        private void MainView_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
