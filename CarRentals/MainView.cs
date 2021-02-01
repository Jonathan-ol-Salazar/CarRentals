﻿using CarRentals.Presenters;
using CarRentals.Views;
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

        public IEnumerable<Rented> RentalReportList 
        {
            get { return (IEnumerable<Rented>)DataGridView_RentalReport.DataSource; }
            set { DataGridView_RentalReport.DataSource = value; }
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
        public string TotalVehiclesRented { get { return Label_TotalVehiclesRented.Text; } set { Label_TotalVehiclesRented.Text = value; } }
        public string TotalDailyRate { get { return Label_TotalDailyRate.Text; } set { Label_TotalDailyRate.Text = value; } }

        public Rented SelectedRented { get { return (Rented)DataGridView_RentalReport.CurrentRow.DataBoundItem; } }

        public Vehicle VehicleSearch { get; set; }

        public string Query { get; set; }
        public bool isQuery { get; set; }
        public Vehicle SelectedVehicleResult { get { return (Vehicle)DataGridView_RentalSearch.CurrentRow.DataBoundItem; } }

        public bool Button_FleetModifyVisible { get { return GroupBox_Fleet_Button_Modify.Visible; } set { GroupBox_Fleet_Button_Modify.Visible = value; } }
        public bool Button_CustomersModifyVisible { get { return GroupBox_Fleet_Button_Modify.Visible; } set { GroupBox_Customers_Button_Modify.Visible = value; } }

        public void SetPresenter(IMainPresenter mainPresenter)
        {
            _mainPresenter = mainPresenter;
        }



        private void ResetGroupBoxFleetForm()
        {
            foreach (Control control in GroupBox_Fleet_Modify_Add.Controls)
            {
                if (!control.Name.Contains("Label") && !control.Name.Contains("Button"))
                {
                    control.ResetText();
                    GroupBox_Fleet_Modify_Add_CheckBox_Sunroof.Checked = false;
                    GroupBox_Fleet_Modify_Add_CheckBox_GPS.Checked = false;
                }
            }
        }

        private void ResetGroupBoxCustomersForm()
        {
            foreach (Control control in GroupBox_Customers_Modify_Add.Controls)
            {
                if (!control.Name.Contains("Label") && !control.Name.Contains("Button"))
                {
                    control.ResetText();
                }
            }
        }

        private void GroupBox_Fleet_Button_Add_Click(object sender, EventArgs e)
        {
            GroupBox_Fleet_Modify_Add.Visible = true;
            GroupBox_Fleet_Modify_Add.Text = "Add Vehicle";
            ResetGroupBoxFleetForm();
            AddVehicle = true;
        }
        private void GroupBox_Fleet_Button_Modify_Click(object sender, EventArgs e)
        {
            GroupBox_Fleet_Modify_Add.Visible = true;
            GroupBox_Fleet_Modify_Add.Text = "Modify Vehicle";
            Label_Rego.Visible = false;
            GroupBox_Fleet_Modify_Add_TextBox_Rego.Visible = false;
            AddVehicle = false;
            _mainPresenter.RefreshVehicleForm();
        }

        private void GroupBox_Fleet_Modify_Add_Button_Cancel_Click(object sender, EventArgs e)
        {
            GroupBox_Fleet_Modify_Add.Visible = false;
        }

        private void GroupBox_Fleet_Modify_Add_Button_Submit_Click(object sender, EventArgs e)
        {
            // Check to see if all fields are filled



            PopupConfirmationView popupConfirmation = new PopupConfirmationView();

            if (AddVehicle == true)
            {
                popupConfirmation.LabelText = "Confirm Vehicle Creation";
                DialogResult dialogResult = popupConfirmation.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    _mainPresenter.AddVehicle();
                }
            }
            else
            {
                popupConfirmation.LabelText = "Confirm Vehicle Update";
                DialogResult dialogResult = popupConfirmation.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    _mainPresenter.UpdateVehicle();
                }
            }
            popupConfirmation.Dispose();
            ResetGroupBoxFleetForm();

        }

        private void GroupBox_Fleet_Button_Remove_Click(object sender, EventArgs e)
        {
            // Check if a vehicle is selected 
            if (DataGridView_Fleet.CurrentRow == null)
            {

            }

            PopupConfirmationView popupConfirmation = new PopupConfirmationView();
            popupConfirmation.LabelText = "Confirm Vehicle Removal";
            DialogResult dialogResult = popupConfirmation.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                _mainPresenter.DeleteVehicle();
            }

            popupConfirmation.Dispose();

            // Resetting Form
            ResetGroupBoxFleetForm();

        }

        private void GroupBox_Customers_Modify_Add_Button_Submit_Click(object sender, EventArgs e)
        {
            PopupConfirmationView popupConfirmation = new PopupConfirmationView();

            if (AddCustomer == true)
            {
                popupConfirmation.LabelText = "Confirm Customer Creation";
                DialogResult dialogResult = popupConfirmation.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    _mainPresenter.AddCustomer();
                }

            }
            else
            {
                popupConfirmation.LabelText = "Confirm Customer Update";
                DialogResult dialogResult = popupConfirmation.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    _mainPresenter.UpdateCustomer();
                }
            }
            popupConfirmation.Dispose();
            ResetGroupBoxCustomersForm();

        }

        private void GroupBox_Customers_Modify_Add_Button_Cancel_Click(object sender, EventArgs e)
        {
            GroupBox_Customers_Modify_Add.Visible = false;
        }

        private void GroupBox_Customers_Button_Remove_Click(object sender, EventArgs e)
        {
            // Check if a customer is selected
            if(DataGridView_Customers.CurrentRow == null)
            {

            }

            PopupConfirmationView popupConfirmation = new PopupConfirmationView();
            popupConfirmation.LabelText = "Confirm Customer Removal";
            DialogResult dialogResult = popupConfirmation.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                _mainPresenter.DeleteCustomer();
            }

            popupConfirmation.Dispose();

            // Resetting Form
            ResetGroupBoxCustomersForm();
        }

        private void GroupBox_Customers_Button_Add_Click(object sender, EventArgs e)
        {
            GroupBox_Customers_Modify_Add.Visible = true;
            GroupBox_Customers_Modify_Add.Text = "Add Customer";
            GroupBox_Customers_Modify_Add_TextBox_CustomerID.Visible = false;
            Label_CustomerID.Visible = false;
            ResetGroupBoxCustomersForm();
            AddCustomer = true;
        }

        private void GroupBox_Customers_Button_Modify_Click(object sender, EventArgs e)
        {
            GroupBox_Customers_Modify_Add.Visible = true;
            GroupBox_Customers_Modify_Add.Text = "Modify Customer";
            GroupBox_Customers_Modify_Add_TextBox_CustomerID.Visible = false;
            Label_CustomerID.Visible = false;
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
                    _mainPresenter.UpdateRentalReportListView();

                    break;
                case 3:
                    _mainPresenter.UpdateRentalSearchListView();

                    break;
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

        private void GroupBox_CreateRental_Enter(object sender, EventArgs e)
        {
            ComboBox_Customer.DataSource = _mainPresenter.GetNotRenting();
            Label_TotalCost.Text = "Total Cost: $" + ((double)NumericUpDown_RentalDuration.Value * SelectedVehicleResult.DailyRate).ToString();

        }

        private void NumericUpDown_RentalDuration_ValueChanged(object sender, EventArgs e)
        {
            Label_TotalCost.Text = "Total Cost: $" + ((double)NumericUpDown_RentalDuration.Value * SelectedVehicleResult.DailyRate).ToString();
        }

        private void Button_Rent_Click(object sender, EventArgs e)
        {
            RentedCustomerID = int.Parse(ComboBox_Customer.Text.Split('-')[0]);
            _mainPresenter.AddRental();
            ComboBox_Customer.SelectedIndex = -1;
            NumericUpDown_RentalDuration.Value = 0;
        }
    }
}
