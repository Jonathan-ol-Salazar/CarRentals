using CarRentals.Presenters;
using DomainLayer.Customers;
using DomainLayer.Rented;
using DomainLayer.Vehicles;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarRentals
{
    public partial class MainView : Form, IMainView
    {
        private bool AddVehicle = false;
        private bool AddCustomer = false;

        public IMainPresenter _mainPresenter;

        public MainView()
        {
            InitializeComponent();

        }

        public IEnumerable<Vehicle> FleetList
        {
            get { return (IEnumerable<Vehicle>)DataGridView_Fleet.DataSource; }
            set { DataGridView_Fleet.DataSource = value; }
        }
        public IEnumerable<Customer> CustomerList
        {
            get { return (IEnumerable<Customer>)DataGridView_Customers.DataSource; }
            set { DataGridView_Customers.DataSource = value; }
        }

        public IEnumerable<Rented> ReportList 
        {
            get { return (IEnumerable<Rented>)DataGridView_Report.DataSource; }
            set { DataGridView_Report.DataSource = value; }
        }
        public IEnumerable<Vehicle> RentalSearchList
        {
            get { return (IEnumerable<Vehicle>)DataGridView_RentalSearch.DataSource; }
            set { DataGridView_RentalSearch.DataSource = value; }
        }


        public string Rego { get { return GroupBox_Fleet_Modify_Add_TextBox_Rego.Text; } set { GroupBox_Fleet_Modify_Add_TextBox_Rego.Text = value; } }
        public string Make { get { return GroupBox_Fleet_Modify_Add_TextBox_Make.Text; } set { GroupBox_Fleet_Modify_Add_TextBox_Make.Text = value; } }
        public string Model { get { return GroupBox_Fleet_Modify_Add_TextBox_Model.Text; } set { GroupBox_Fleet_Modify_Add_TextBox_Model.Text = value; } }
        public string Class { get { return GroupBox_Fleet_Modify_Add_ComboBox_Class.Text; } set { GroupBox_Fleet_Modify_Add_ComboBox_Class.Text = value; } }
        public string Year { get { return GroupBox_Fleet_Modify_Add_TextBox_Year.Text; } set { GroupBox_Fleet_Modify_Add_TextBox_Year.Text = value; } }
        public string Transmission { get { return GroupBox_Fleet_Modify_Add_ComboBox_Transmission.Text; } set { GroupBox_Fleet_Modify_Add_ComboBox_Transmission.Text = value; } }
        public string Fuel { get { return GroupBox_Fleet_Modify_Add_ComboBox_Fuel.Text; } set { GroupBox_Fleet_Modify_Add_ComboBox_Fuel.Text = value; } }
        public int Seats { get { return (int)GroupBox_Fleet_Modify_Add_NumericUpDown_Seats.Value; } set { GroupBox_Fleet_Modify_Add_NumericUpDown_Seats.Value = value; } }
        public bool Sunroof { get { return GroupBox_Fleet_Modify_Add_CheckBox_Sunroof.Checked; } set { GroupBox_Fleet_Modify_Add_CheckBox_Sunroof.Checked = value; } }
        public bool GPS { get { return GroupBox_Fleet_Modify_Add_CheckBox_GPS.Checked; } set { GroupBox_Fleet_Modify_Add_CheckBox_GPS.Checked = value; } }
        public string Colour { get { return GroupBox_Fleet_Modify_Add_TextBox_Colour.Text; } set { GroupBox_Fleet_Modify_Add_TextBox_Colour.Text = value; } }
        public double DailyRate { get { return (double)GroupBox_Fleet_Modify_Add_NumericUpDown_DailyRate.Value; } set { GroupBox_Fleet_Modify_Add_NumericUpDown_DailyRate.Value = (decimal)value; } }

        public Vehicle SelectedVehicle { get { return (Vehicle)DataGridView_Fleet.CurrentRow.DataBoundItem; } }

        public int CustomerID { get { return int.Parse(GroupBox_Customers_Modify_Add_TextBox_CustomerID.Text); } set { GroupBox_Customers_Modify_Add_TextBox_CustomerID.Text = value.ToString(); } }
        public string FirstName { get { return GroupBox_Customers_Modify_Add_TextBox_FirstName.Text; } set { GroupBox_Customers_Modify_Add_TextBox_FirstName.Text = value; } }
        public string LastName { get { return GroupBox_Customers_Modify_Add_TextBox_LastName.Text; } set { GroupBox_Customers_Modify_Add_TextBox_LastName.Text = value; } }
        public string DOB { get { return GroupBox_Customers_Modify_Add_TextBox_DOB.Text; } set { GroupBox_Customers_Modify_Add_TextBox_DOB.Text = value; } }
        public string Gender { get { return GroupBox_Customers_Modify_Add_ComboBox_Gender.Text; } set { GroupBox_Customers_Modify_Add_ComboBox_Gender.Text = value; } }
        public string Title { get { return GroupBox_Customers_Modify_Add_ComboBox_Title.Text; } set { GroupBox_Customers_Modify_Add_ComboBox_Title.Text = value; } }

        public Customer SelectedCustomer { get { return (Customer)DataGridView_Customers.CurrentRow.DataBoundItem; } }


        public int RentedCustomerID { get; set; }
        public string RentedRego { get; set; }
        public double RentedDailyRate { get; set; }

        public Rented SelectedRented { get; set; }

        public Vehicle VehicleSearch { get; set; }

        public string Query { get; set; }
        public bool isQuery { get; set; }



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
            GroupBox_Fleet_Modify_Add.Visible = true;
            GroupBox_Fleet_Modify_Add.Text = "Add Vehicle";
            AddVehicle = true;

        }
        private void GroupBox_Fleet_Button_Modify_Click(object sender, EventArgs e)
        {
            GroupBox_Fleet_Modify_Add.Visible = true;
            GroupBox_Fleet_Modify_Add.Text = "Modify Vehicle";
            AddVehicle = false;
            _mainPresenter.RefreshVehicleForm();
        }

        private void GroupBox_Fleet_Modify_Add_Button_Cancel_Click(object sender, EventArgs e)
        {
            // Fix: not functional
            GroupBox_Fleet_Modify_Add.Visible = false;
            GroupBox_Fleet_Modify_Add.Enabled = false;
        }



        private void GroupBox_Fleet_Modify_Add_Button_Submit_Click(object sender, EventArgs e)
        {
            if(AddVehicle == true)
            {
                _mainPresenter.AddVehicle();

            }
            else
            {
                _mainPresenter.UpdateVehicle();
            }
        }

        private void GroupBox_Fleet_Button_Remove_Click(object sender, EventArgs e)
        {
            _mainPresenter.DeleteVehicle();
        }

        private void GroupBox_Customers_Modify_Add_Button_Submit_Click(object sender, EventArgs e)
        {
            if (AddCustomer == true)
            {
                _mainPresenter.AddCustomer();

            }
            else
            {
                _mainPresenter.UpdateCustomer();
            }
        }

        private void GroupBox_Customers_Modify_Add_Button_Cancel_Click(object sender, EventArgs e)
        {
            // Fix: not functional
            GroupBox_Customers_Modify_Add.Visible = false;

        }

        private void GroupBox_Customers_Button_Remove_Click(object sender, EventArgs e)
        {
            _mainPresenter.DeleteCustomer();
        }

        private void GroupBox_Customers_Button_Add_Click(object sender, EventArgs e)
        {
            GroupBox_Customers_Modify_Add.Visible = true;
            GroupBox_Customers_Modify_Add.Text = "Add Customer";
            GroupBox_Customers_Modify_Add_TextBox_CustomerID.Visible = false;
            Label_CustomerID.Visible = false;

            AddCustomer = true;
        }

        private void GroupBox_Customers_Button_Modify_Click(object sender, EventArgs e)
        {
            GroupBox_Customers_Modify_Add.Visible = true;
            GroupBox_Customers_Modify_Add.Text = "Modify Customer";
            GroupBox_Customers_Modify_Add_TextBox_CustomerID.Visible = true;
            Label_CustomerID.Visible = true;
            AddCustomer = false;
            _mainPresenter.RefreshCustomerForm();
        }

        private void TabControl_MainView_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TabControl_MainView.SelectedIndex)
            {
                case 0:
                    _mainPresenter.UpdateFleetListView();
                    break;
                case 1:
                    _mainPresenter.UpdateCustomerListView();

                    break;
                case 2:
                    _mainPresenter.UpdateReportListView();

                    break;
                //case 3:
                //    _mainPresenter.UpdateReportListView();

                //    break;
            }
        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            isQuery = true;
            _mainPresenter.UpdateRentalSearchListView();
        }

        private void Button_ShowAll_Click(object sender, EventArgs e)
        {
            isQuery = false;
            _mainPresenter.UpdateRentalSearchListView();
        }

        private void ComboBox_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void GroupBox_CreateRental_Enter(object sender, EventArgs e)
        {
            ComboBox_Customer.DataSource = _mainPresenter.GetNotRenting();

        }
    }
}
