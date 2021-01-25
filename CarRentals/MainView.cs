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

        public MainView(VehicleRepository vehicleRepository)
        {
            InitializeComponent();

            // Adding Datasource
            DataGridView dataGridView = new DataGridView();
            dataGridView.AutoGenerateColumns = true;
            var data = dataGridView.DataSource = vehicleRepository.GetAll().ToList();
            //this.Controls.Add(dataGridView);
            dataGridView1.DataSource = vehicleRepository.GetAll().ToList();

           

        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
