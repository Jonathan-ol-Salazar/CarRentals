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

        public string Rego { get { return this.GroupBox_Modify_Add_TextBox_Rego.Text; } set { this.GroupBox_Modify_Add_TextBox_Rego.Text = value; } }
        public string Make { get { return this.GroupBox_Modify_Add_TextBox_Make.Text; } set { this.GroupBox_Modify_Add_TextBox_Make.Text = value; } }
        public string Model { get { return this.GroupBox_Modify_Add_TextBox_Model.Text; } set { this.GroupBox_Modify_Add_TextBox_Model.Text = value; } }
        public string Class { get { return this.GroupBox_Modify_Add_ComboBox_Class.Text; } set { this.GroupBox_Modify_Add_ComboBox_Class.Text = value; } }
        public int Year { get { return Int32.Parse(this.GroupBox_Modify_Add_TextBox_Year.Text); } set { this.Year = value; } }
        public string Transmission { get { return this.GroupBox_Modify_Add_ComboBox_Transmission.Text; } set { this.GroupBox_Modify_Add_ComboBox_Transmission.Text = value; } }
        public string Fuel { get { return this.GroupBox_Modify_Add_ComboBox_Fuel.Text; } set { this.GroupBox_Modify_Add_ComboBox_Fuel.Text = value; } }
        public int Seats { get { return (int)this.GroupBox_Modify_Add_NumericUpDown_Seats.Value; } set { this.GroupBox_Modify_Add_NumericUpDown_Seats.Value = value; } }
        public bool Sunroof { get { return this.GroupBox_Modify_Add_CheckBox_Sunroof.Checked; } set { this.GroupBox_Modify_Add_CheckBox_Sunroof.Checked = value; } }
        public bool GPS { get { return this.GroupBox_Modify_Add_CheckBox_GPS.Checked; } set { this.GroupBox_Modify_Add_CheckBox_GPS.Checked = value; } }
        public string Colour { get { return this.GroupBox_Modify_Add_TextBox_Colour.Text; } set { this.GroupBox_Modify_Add_TextBox_Colour.Text = value; } }
        public int DailyRate { get { return (int)this.GroupBox_Modify_Add_NumericUpDown_DailyRate.Value; } set { this.GroupBox_Modify_Add_NumericUpDown_DailyRate.Value = value; } }

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

        private void GroupBox_Fleet_Button_Add_Click(object sender, EventArgs e)
        {
            this.GroupBox_Modify_Add.Visible = true;
            this.GroupBox_Modify_Add.Text = "Add Vehicle";


        }

        private void GroupBox_Modify_Add_Button_Cancel_Click(object sender, EventArgs e)
        {
            // Fix: not functional
            this.GroupBox_Modify_Add.Visible = false;
            this.GroupBox_Modify_Add.Enabled = false;


        }

        private void GroupBox_Fleet_Button_Modify_Click(object sender, EventArgs e)
        {
            this.GroupBox_Modify_Add.Visible = true;
            this.GroupBox_Modify_Add.Text = "Modify Vehicle";
        }

        private void GroupBox_Modify_Add_Button_Submit_Click(object sender, EventArgs e)
        {
            _mainPresenter.SaveNewVehicle();
        }




    }
}
