
using DomainLayer.Customers;
using DomainLayer.Vehicles;
using System;

namespace CarRentals
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl_MainView = new System.Windows.Forms.TabControl();
            this.FleetTab = new System.Windows.Forms.TabPage();
            this.GroupBox_Fleet_Modify_Add = new System.Windows.Forms.GroupBox();
            this.GroupBox_Fleet_Modify_Add_NumericUpDown_DailyRate = new System.Windows.Forms.NumericUpDown();
            this.GroupBox_Fleet_Modify_Add_NumericUpDown_Seats = new System.Windows.Forms.NumericUpDown();
            this.GroupBox_Fleet_Modify_Add_CheckBox_GPS = new System.Windows.Forms.CheckBox();
            this.GroupBox_Fleet_Modify_Add_CheckBox_Sunroof = new System.Windows.Forms.CheckBox();
            this.GroupBox_Fleet_Modify_Add_ComboBox_Fuel = new System.Windows.Forms.ComboBox();
            this.GroupBox_Fleet_Modify_Add_ComboBox_Class = new System.Windows.Forms.ComboBox();
            this.GroupBox_Fleet_Modify_Add_ComboBox_Transmission = new System.Windows.Forms.ComboBox();
            this.GroupBox_Fleet_Modify_Add_Button_Cancel = new System.Windows.Forms.Button();
            this.GroupBox_Fleet_Modify_Add_Button_Submit = new System.Windows.Forms.Button();
            this.Label_GPS = new System.Windows.Forms.Label();
            this.Label_Class = new System.Windows.Forms.Label();
            this.Label_Transmission = new System.Windows.Forms.Label();
            this.Label_Fuel = new System.Windows.Forms.Label();
            this.Label_Seats = new System.Windows.Forms.Label();
            this.Label_Sunroof = new System.Windows.Forms.Label();
            this.Label_DailyRate = new System.Windows.Forms.Label();
            this.GroupBox_Fleet_Modify_Add_TextBox_Colour = new System.Windows.Forms.TextBox();
            this.Label_Colour = new System.Windows.Forms.Label();
            this.GroupBox_Fleet_Modify_Add_TextBox_Year = new System.Windows.Forms.TextBox();
            this.Label_Year = new System.Windows.Forms.Label();
            this.GroupBox_Fleet_Modify_Add_TextBox_Make = new System.Windows.Forms.TextBox();
            this.Label_Make = new System.Windows.Forms.Label();
            this.GroupBox_Fleet_Modify_Add_TextBox_Model = new System.Windows.Forms.TextBox();
            this.Label_Model = new System.Windows.Forms.Label();
            this.GroupBox_Fleet_Modify_Add_TextBox_Rego = new System.Windows.Forms.TextBox();
            this.Label_Rego = new System.Windows.Forms.Label();
            this.GroupBox_Fleet = new System.Windows.Forms.GroupBox();
            this.GroupBox_Fleet_Button_Add = new System.Windows.Forms.Button();
            this.GroupBox_Fleet_Button_Remove = new System.Windows.Forms.Button();
            this.GroupBox_Fleet_Button_Modify = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DataGridView_Fleet = new System.Windows.Forms.DataGridView();
            this.CustomersTab = new System.Windows.Forms.TabPage();
            this.GroupBox_Customers = new System.Windows.Forms.GroupBox();
            this.GroupBox_Customers_Button_Add = new System.Windows.Forms.Button();
            this.GroupBox_Customers_Button_Remove = new System.Windows.Forms.Button();
            this.GroupBox_Customers_Button_Modify = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.GroupBox_Customers_Modify_Add = new System.Windows.Forms.GroupBox();
            this.GroupBox_Customers_Modify_Add_ComboBox_Gender = new System.Windows.Forms.ComboBox();
            this.GroupBox_Customers_Modify_Add_Button_Cancel = new System.Windows.Forms.Button();
            this.GroupBox_Customers_Modify_Add_Button_Submit = new System.Windows.Forms.Button();
            this.GroupBox_Customers_Modify_Add_ComboBox_Title = new System.Windows.Forms.ComboBox();
            this.GroupBox_Customers_Modify_Add_TextBox_DOB = new System.Windows.Forms.TextBox();
            this.Label_DOB = new System.Windows.Forms.Label();
            this.Label_Title = new System.Windows.Forms.Label();
            this.Label_Gender = new System.Windows.Forms.Label();
            this.GroupBox_Customers_Modify_Add_TextBox_FirstName = new System.Windows.Forms.TextBox();
            this.Label_FirstName = new System.Windows.Forms.Label();
            this.GroupBox_Customers_Modify_Add_TextBox_LastName = new System.Windows.Forms.TextBox();
            this.Label_LastName = new System.Windows.Forms.Label();
            this.Label_CustomerID = new System.Windows.Forms.Label();
            this.DataGridView_Customers = new System.Windows.Forms.DataGridView();
            this.RentalReportTab = new System.Windows.Forms.TabPage();
            this.GroupBox_Report = new System.Windows.Forms.GroupBox();
            this.Label_TotalVehiclesRented = new System.Windows.Forms.Label();
            this.Label_TotalDailyRate = new System.Windows.Forms.Label();
            this.GroupBox_Report_Button_Return = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView_RentalReport = new System.Windows.Forms.DataGridView();
            this.RentalSearchTab = new System.Windows.Forms.TabPage();
            this.Label_DailyCostRangeMinus = new System.Windows.Forms.Label();
            this.Label_DailyCostRange = new System.Windows.Forms.Label();
            this.TextBox_Query = new System.Windows.Forms.TextBox();
            this.NumericUpDown_DailyCostRangeTop = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown_DailyCostRangeBottom = new System.Windows.Forms.NumericUpDown();
            this.Button_ShowAll = new System.Windows.Forms.Button();
            this.Button_Search = new System.Windows.Forms.Button();
            this.GroupBox_Results = new System.Windows.Forms.GroupBox();
            this.GroupBox_CreateRental = new System.Windows.Forms.GroupBox();
            this.Label_TotalCost = new System.Windows.Forms.Label();
            this.Label_RentalDuration = new System.Windows.Forms.Label();
            this.NumericUpDown_RentalDuration = new System.Windows.Forms.NumericUpDown();
            this.Button_Rent = new System.Windows.Forms.Button();
            this.Label_Customer = new System.Windows.Forms.Label();
            this.ComboBox_Customer = new System.Windows.Forms.ComboBox();
            this.DataGridView_RentalSearch = new System.Windows.Forms.DataGridView();
            this.TabControl_MainView.SuspendLayout();
            this.FleetTab.SuspendLayout();
            this.GroupBox_Fleet_Modify_Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox_Fleet_Modify_Add_NumericUpDown_DailyRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox_Fleet_Modify_Add_NumericUpDown_Seats)).BeginInit();
            this.GroupBox_Fleet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Fleet)).BeginInit();
            this.CustomersTab.SuspendLayout();
            this.GroupBox_Customers.SuspendLayout();
            this.GroupBox_Customers_Modify_Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Customers)).BeginInit();
            this.RentalReportTab.SuspendLayout();
            this.GroupBox_Report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_RentalReport)).BeginInit();
            this.RentalSearchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_DailyCostRangeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_DailyCostRangeBottom)).BeginInit();
            this.GroupBox_Results.SuspendLayout();
            this.GroupBox_CreateRental.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_RentalDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_RentalSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl_MainView
            // 
            this.TabControl_MainView.Controls.Add(this.FleetTab);
            this.TabControl_MainView.Controls.Add(this.CustomersTab);
            this.TabControl_MainView.Controls.Add(this.RentalReportTab);
            this.TabControl_MainView.Controls.Add(this.RentalSearchTab);
            this.TabControl_MainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl_MainView.Location = new System.Drawing.Point(0, 0);
            this.TabControl_MainView.Name = "TabControl_MainView";
            this.TabControl_MainView.SelectedIndex = 0;
            this.TabControl_MainView.Size = new System.Drawing.Size(800, 692);
            this.TabControl_MainView.TabIndex = 0;
            this.TabControl_MainView.SelectedIndexChanged += new System.EventHandler(this.TabControl_MainView_SelectedIndexChanged);
            // 
            // FleetTab
            // 
            this.FleetTab.Controls.Add(this.GroupBox_Fleet_Modify_Add);
            this.FleetTab.Controls.Add(this.GroupBox_Fleet);
            this.FleetTab.Controls.Add(this.DataGridView_Fleet);
            this.FleetTab.Location = new System.Drawing.Point(4, 24);
            this.FleetTab.Name = "FleetTab";
            this.FleetTab.Padding = new System.Windows.Forms.Padding(3);
            this.FleetTab.Size = new System.Drawing.Size(792, 664);
            this.FleetTab.TabIndex = 0;
            this.FleetTab.Text = "Fleet";
            this.FleetTab.UseVisualStyleBackColor = true;
            // 
            // GroupBox_Fleet_Modify_Add
            // 
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.GroupBox_Fleet_Modify_Add_NumericUpDown_DailyRate);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.GroupBox_Fleet_Modify_Add_NumericUpDown_Seats);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.GroupBox_Fleet_Modify_Add_CheckBox_GPS);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.GroupBox_Fleet_Modify_Add_CheckBox_Sunroof);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.GroupBox_Fleet_Modify_Add_ComboBox_Fuel);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.GroupBox_Fleet_Modify_Add_ComboBox_Class);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.GroupBox_Fleet_Modify_Add_ComboBox_Transmission);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.GroupBox_Fleet_Modify_Add_Button_Cancel);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.GroupBox_Fleet_Modify_Add_Button_Submit);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.Label_GPS);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.Label_Class);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.Label_Transmission);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.Label_Fuel);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.Label_Seats);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.Label_Sunroof);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.Label_DailyRate);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.GroupBox_Fleet_Modify_Add_TextBox_Colour);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.Label_Colour);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.GroupBox_Fleet_Modify_Add_TextBox_Year);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.Label_Year);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.GroupBox_Fleet_Modify_Add_TextBox_Make);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.Label_Make);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.GroupBox_Fleet_Modify_Add_TextBox_Model);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.Label_Model);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.GroupBox_Fleet_Modify_Add_TextBox_Rego);
            this.GroupBox_Fleet_Modify_Add.Controls.Add(this.Label_Rego);
            this.GroupBox_Fleet_Modify_Add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupBox_Fleet_Modify_Add.Location = new System.Drawing.Point(3, 413);
            this.GroupBox_Fleet_Modify_Add.Name = "GroupBox_Fleet_Modify_Add";
            this.GroupBox_Fleet_Modify_Add.Size = new System.Drawing.Size(786, 193);
            this.GroupBox_Fleet_Modify_Add.TabIndex = 3;
            this.GroupBox_Fleet_Modify_Add.TabStop = false;
            this.GroupBox_Fleet_Modify_Add.Text = "groupBox1";
            this.GroupBox_Fleet_Modify_Add.Visible = false;
            // 
            // GroupBox_Fleet_Modify_Add_NumericUpDown_DailyRate
            // 
            this.GroupBox_Fleet_Modify_Add_NumericUpDown_DailyRate.Location = new System.Drawing.Point(489, 112);
            this.GroupBox_Fleet_Modify_Add_NumericUpDown_DailyRate.Name = "GroupBox_Fleet_Modify_Add_NumericUpDown_DailyRate";
            this.GroupBox_Fleet_Modify_Add_NumericUpDown_DailyRate.Size = new System.Drawing.Size(31, 23);
            this.GroupBox_Fleet_Modify_Add_NumericUpDown_DailyRate.TabIndex = 12;
            // 
            // GroupBox_Fleet_Modify_Add_NumericUpDown_Seats
            // 
            this.GroupBox_Fleet_Modify_Add_NumericUpDown_Seats.Location = new System.Drawing.Point(271, 149);
            this.GroupBox_Fleet_Modify_Add_NumericUpDown_Seats.Name = "GroupBox_Fleet_Modify_Add_NumericUpDown_Seats";
            this.GroupBox_Fleet_Modify_Add_NumericUpDown_Seats.Size = new System.Drawing.Size(31, 23);
            this.GroupBox_Fleet_Modify_Add_NumericUpDown_Seats.TabIndex = 8;
            // 
            // GroupBox_Fleet_Modify_Add_CheckBox_GPS
            // 
            this.GroupBox_Fleet_Modify_Add_CheckBox_GPS.AutoSize = true;
            this.GroupBox_Fleet_Modify_Add_CheckBox_GPS.Location = new System.Drawing.Point(573, 37);
            this.GroupBox_Fleet_Modify_Add_CheckBox_GPS.Name = "GroupBox_Fleet_Modify_Add_CheckBox_GPS";
            this.GroupBox_Fleet_Modify_Add_CheckBox_GPS.Size = new System.Drawing.Size(15, 14);
            this.GroupBox_Fleet_Modify_Add_CheckBox_GPS.TabIndex = 10;
            this.GroupBox_Fleet_Modify_Add_CheckBox_GPS.UseVisualStyleBackColor = true;
            // 
            // GroupBox_Fleet_Modify_Add_CheckBox_Sunroof
            // 
            this.GroupBox_Fleet_Modify_Add_CheckBox_Sunroof.AutoSize = true;
            this.GroupBox_Fleet_Modify_Add_CheckBox_Sunroof.Location = new System.Drawing.Point(489, 38);
            this.GroupBox_Fleet_Modify_Add_CheckBox_Sunroof.Name = "GroupBox_Fleet_Modify_Add_CheckBox_Sunroof";
            this.GroupBox_Fleet_Modify_Add_CheckBox_Sunroof.Size = new System.Drawing.Size(15, 14);
            this.GroupBox_Fleet_Modify_Add_CheckBox_Sunroof.TabIndex = 9;
            this.GroupBox_Fleet_Modify_Add_CheckBox_Sunroof.UseVisualStyleBackColor = true;
            // 
            // GroupBox_Fleet_Modify_Add_ComboBox_Fuel
            // 
            this.GroupBox_Fleet_Modify_Add_ComboBox_Fuel.FormattingEnabled = true;
            this.GroupBox_Fleet_Modify_Add_ComboBox_Fuel.Location = new System.Drawing.Point(271, 111);
            this.GroupBox_Fleet_Modify_Add_ComboBox_Fuel.Name = "GroupBox_Fleet_Modify_Add_ComboBox_Fuel";
            this.GroupBox_Fleet_Modify_Add_ComboBox_Fuel.Size = new System.Drawing.Size(108, 23);
            this.GroupBox_Fleet_Modify_Add_ComboBox_Fuel.TabIndex = 7;
            // 
            // GroupBox_Fleet_Modify_Add_ComboBox_Class
            // 
            this.GroupBox_Fleet_Modify_Add_ComboBox_Class.FormattingEnabled = true;
            this.GroupBox_Fleet_Modify_Add_ComboBox_Class.Location = new System.Drawing.Point(70, 148);
            this.GroupBox_Fleet_Modify_Add_ComboBox_Class.Name = "GroupBox_Fleet_Modify_Add_ComboBox_Class";
            this.GroupBox_Fleet_Modify_Add_ComboBox_Class.Size = new System.Drawing.Size(100, 23);
            this.GroupBox_Fleet_Modify_Add_ComboBox_Class.TabIndex = 4;
            // 
            // GroupBox_Fleet_Modify_Add_ComboBox_Transmission
            // 
            this.GroupBox_Fleet_Modify_Add_ComboBox_Transmission.FormattingEnabled = true;
            this.GroupBox_Fleet_Modify_Add_ComboBox_Transmission.Location = new System.Drawing.Point(271, 74);
            this.GroupBox_Fleet_Modify_Add_ComboBox_Transmission.Name = "GroupBox_Fleet_Modify_Add_ComboBox_Transmission";
            this.GroupBox_Fleet_Modify_Add_ComboBox_Transmission.Size = new System.Drawing.Size(108, 23);
            this.GroupBox_Fleet_Modify_Add_ComboBox_Transmission.TabIndex = 6;
            // 
            // GroupBox_Fleet_Modify_Add_Button_Cancel
            // 
            this.GroupBox_Fleet_Modify_Add_Button_Cancel.Location = new System.Drawing.Point(703, 151);
            this.GroupBox_Fleet_Modify_Add_Button_Cancel.Name = "GroupBox_Fleet_Modify_Add_Button_Cancel";
            this.GroupBox_Fleet_Modify_Add_Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.GroupBox_Fleet_Modify_Add_Button_Cancel.TabIndex = 14;
            this.GroupBox_Fleet_Modify_Add_Button_Cancel.Text = "Cancel";
            this.GroupBox_Fleet_Modify_Add_Button_Cancel.UseVisualStyleBackColor = true;
            this.GroupBox_Fleet_Modify_Add_Button_Cancel.Click += new System.EventHandler(this.GroupBox_Fleet_Modify_Add_Button_Cancel_Click);
            // 
            // GroupBox_Fleet_Modify_Add_Button_Submit
            // 
            this.GroupBox_Fleet_Modify_Add_Button_Submit.Location = new System.Drawing.Point(622, 151);
            this.GroupBox_Fleet_Modify_Add_Button_Submit.Name = "GroupBox_Fleet_Modify_Add_Button_Submit";
            this.GroupBox_Fleet_Modify_Add_Button_Submit.Size = new System.Drawing.Size(75, 23);
            this.GroupBox_Fleet_Modify_Add_Button_Submit.TabIndex = 13;
            this.GroupBox_Fleet_Modify_Add_Button_Submit.Text = "Submit";
            this.GroupBox_Fleet_Modify_Add_Button_Submit.UseVisualStyleBackColor = true;
            this.GroupBox_Fleet_Modify_Add_Button_Submit.Click += new System.EventHandler(this.GroupBox_Fleet_Modify_Add_Button_Submit_Click);
            // 
            // Label_GPS
            // 
            this.Label_GPS.AutoSize = true;
            this.Label_GPS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_GPS.Location = new System.Drawing.Point(534, 37);
            this.Label_GPS.Name = "Label_GPS";
            this.Label_GPS.Size = new System.Drawing.Size(33, 15);
            this.Label_GPS.TabIndex = 20;
            this.Label_GPS.Text = "GPS:";
            // 
            // Label_Class
            // 
            this.Label_Class.AutoSize = true;
            this.Label_Class.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Class.Location = new System.Drawing.Point(30, 151);
            this.Label_Class.Name = "Label_Class";
            this.Label_Class.Size = new System.Drawing.Size(36, 15);
            this.Label_Class.TabIndex = 18;
            this.Label_Class.Text = "Class:";
            // 
            // Label_Transmission
            // 
            this.Label_Transmission.AutoSize = true;
            this.Label_Transmission.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Transmission.Location = new System.Drawing.Point(180, 77);
            this.Label_Transmission.Name = "Label_Transmission";
            this.Label_Transmission.Size = new System.Drawing.Size(80, 15);
            this.Label_Transmission.TabIndex = 17;
            this.Label_Transmission.Text = "Transmission:";
            // 
            // Label_Fuel
            // 
            this.Label_Fuel.AutoSize = true;
            this.Label_Fuel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Fuel.Location = new System.Drawing.Point(227, 114);
            this.Label_Fuel.Name = "Label_Fuel";
            this.Label_Fuel.Size = new System.Drawing.Size(33, 15);
            this.Label_Fuel.TabIndex = 16;
            this.Label_Fuel.Text = "Fuel:";
            // 
            // Label_Seats
            // 
            this.Label_Seats.AutoSize = true;
            this.Label_Seats.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Seats.Location = new System.Drawing.Point(220, 151);
            this.Label_Seats.Name = "Label_Seats";
            this.Label_Seats.Size = new System.Drawing.Size(40, 15);
            this.Label_Seats.TabIndex = 15;
            this.Label_Seats.Text = "Seats:";
            // 
            // Label_Sunroof
            // 
            this.Label_Sunroof.AutoSize = true;
            this.Label_Sunroof.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Sunroof.Location = new System.Drawing.Point(428, 37);
            this.Label_Sunroof.Name = "Label_Sunroof";
            this.Label_Sunroof.Size = new System.Drawing.Size(55, 15);
            this.Label_Sunroof.TabIndex = 14;
            this.Label_Sunroof.Text = "Sunroof:";
            // 
            // Label_DailyRate
            // 
            this.Label_DailyRate.AutoSize = true;
            this.Label_DailyRate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_DailyRate.Location = new System.Drawing.Point(417, 117);
            this.Label_DailyRate.Name = "Label_DailyRate";
            this.Label_DailyRate.Size = new System.Drawing.Size(66, 15);
            this.Label_DailyRate.TabIndex = 12;
            this.Label_DailyRate.Text = "Daily Rate:";
            // 
            // GroupBox_Fleet_Modify_Add_TextBox_Colour
            // 
            this.GroupBox_Fleet_Modify_Add_TextBox_Colour.Location = new System.Drawing.Point(489, 74);
            this.GroupBox_Fleet_Modify_Add_TextBox_Colour.Name = "GroupBox_Fleet_Modify_Add_TextBox_Colour";
            this.GroupBox_Fleet_Modify_Add_TextBox_Colour.Size = new System.Drawing.Size(99, 23);
            this.GroupBox_Fleet_Modify_Add_TextBox_Colour.TabIndex = 11;
            // 
            // Label_Colour
            // 
            this.Label_Colour.AutoSize = true;
            this.Label_Colour.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Colour.Location = new System.Drawing.Point(437, 77);
            this.Label_Colour.Name = "Label_Colour";
            this.Label_Colour.Size = new System.Drawing.Size(46, 15);
            this.Label_Colour.TabIndex = 10;
            this.Label_Colour.Text = "Colour:";
            // 
            // GroupBox_Fleet_Modify_Add_TextBox_Year
            // 
            this.GroupBox_Fleet_Modify_Add_TextBox_Year.Location = new System.Drawing.Point(271, 34);
            this.GroupBox_Fleet_Modify_Add_TextBox_Year.Name = "GroupBox_Fleet_Modify_Add_TextBox_Year";
            this.GroupBox_Fleet_Modify_Add_TextBox_Year.Size = new System.Drawing.Size(108, 23);
            this.GroupBox_Fleet_Modify_Add_TextBox_Year.TabIndex = 5;
            // 
            // Label_Year
            // 
            this.Label_Year.AutoSize = true;
            this.Label_Year.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Year.Location = new System.Drawing.Point(226, 37);
            this.Label_Year.Name = "Label_Year";
            this.Label_Year.Size = new System.Drawing.Size(34, 15);
            this.Label_Year.TabIndex = 8;
            this.Label_Year.Text = "Year:";
            // 
            // GroupBox_Fleet_Modify_Add_TextBox_Make
            // 
            this.GroupBox_Fleet_Modify_Add_TextBox_Make.Location = new System.Drawing.Point(70, 74);
            this.GroupBox_Fleet_Modify_Add_TextBox_Make.Name = "GroupBox_Fleet_Modify_Add_TextBox_Make";
            this.GroupBox_Fleet_Modify_Add_TextBox_Make.Size = new System.Drawing.Size(100, 23);
            this.GroupBox_Fleet_Modify_Add_TextBox_Make.TabIndex = 2;
            // 
            // Label_Make
            // 
            this.Label_Make.AutoSize = true;
            this.Label_Make.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Make.Location = new System.Drawing.Point(25, 77);
            this.Label_Make.Name = "Label_Make";
            this.Label_Make.Size = new System.Drawing.Size(41, 15);
            this.Label_Make.TabIndex = 6;
            this.Label_Make.Text = "Make:";
            // 
            // GroupBox_Fleet_Modify_Add_TextBox_Model
            // 
            this.GroupBox_Fleet_Modify_Add_TextBox_Model.Location = new System.Drawing.Point(70, 111);
            this.GroupBox_Fleet_Modify_Add_TextBox_Model.Name = "GroupBox_Fleet_Modify_Add_TextBox_Model";
            this.GroupBox_Fleet_Modify_Add_TextBox_Model.Size = new System.Drawing.Size(100, 23);
            this.GroupBox_Fleet_Modify_Add_TextBox_Model.TabIndex = 3;
            // 
            // Label_Model
            // 
            this.Label_Model.AutoSize = true;
            this.Label_Model.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Model.Location = new System.Drawing.Point(21, 114);
            this.Label_Model.Name = "Label_Model";
            this.Label_Model.Size = new System.Drawing.Size(45, 15);
            this.Label_Model.TabIndex = 2;
            this.Label_Model.Text = "Model:";
            // 
            // GroupBox_Fleet_Modify_Add_TextBox_Rego
            // 
            this.GroupBox_Fleet_Modify_Add_TextBox_Rego.Location = new System.Drawing.Point(70, 34);
            this.GroupBox_Fleet_Modify_Add_TextBox_Rego.Name = "GroupBox_Fleet_Modify_Add_TextBox_Rego";
            this.GroupBox_Fleet_Modify_Add_TextBox_Rego.Size = new System.Drawing.Size(100, 23);
            this.GroupBox_Fleet_Modify_Add_TextBox_Rego.TabIndex = 1;
            // 
            // Label_Rego
            // 
            this.Label_Rego.AutoSize = true;
            this.Label_Rego.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Rego.Location = new System.Drawing.Point(27, 37);
            this.Label_Rego.Name = "Label_Rego";
            this.Label_Rego.Size = new System.Drawing.Size(39, 15);
            this.Label_Rego.TabIndex = 0;
            this.Label_Rego.Text = "Rego:";
            // 
            // GroupBox_Fleet
            // 
            this.GroupBox_Fleet.Controls.Add(this.GroupBox_Fleet_Button_Add);
            this.GroupBox_Fleet.Controls.Add(this.GroupBox_Fleet_Button_Remove);
            this.GroupBox_Fleet.Controls.Add(this.GroupBox_Fleet_Button_Modify);
            this.GroupBox_Fleet.Controls.Add(this.label6);
            this.GroupBox_Fleet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupBox_Fleet.Location = new System.Drawing.Point(3, 606);
            this.GroupBox_Fleet.Name = "GroupBox_Fleet";
            this.GroupBox_Fleet.Size = new System.Drawing.Size(786, 55);
            this.GroupBox_Fleet.TabIndex = 2;
            this.GroupBox_Fleet.TabStop = false;
            this.GroupBox_Fleet.Text = "Modify Fleet";
            // 
            // GroupBox_Fleet_Button_Add
            // 
            this.GroupBox_Fleet_Button_Add.Location = new System.Drawing.Point(695, 22);
            this.GroupBox_Fleet_Button_Add.Name = "GroupBox_Fleet_Button_Add";
            this.GroupBox_Fleet_Button_Add.Size = new System.Drawing.Size(75, 23);
            this.GroupBox_Fleet_Button_Add.TabIndex = 2;
            this.GroupBox_Fleet_Button_Add.Text = "Add";
            this.GroupBox_Fleet_Button_Add.UseVisualStyleBackColor = true;
            this.GroupBox_Fleet_Button_Add.Click += new System.EventHandler(this.GroupBox_Fleet_Button_Add_Click);
            // 
            // GroupBox_Fleet_Button_Remove
            // 
            this.GroupBox_Fleet_Button_Remove.Location = new System.Drawing.Point(87, 22);
            this.GroupBox_Fleet_Button_Remove.Name = "GroupBox_Fleet_Button_Remove";
            this.GroupBox_Fleet_Button_Remove.Size = new System.Drawing.Size(75, 23);
            this.GroupBox_Fleet_Button_Remove.TabIndex = 1;
            this.GroupBox_Fleet_Button_Remove.Text = "Remove";
            this.GroupBox_Fleet_Button_Remove.UseVisualStyleBackColor = true;
            this.GroupBox_Fleet_Button_Remove.Click += new System.EventHandler(this.GroupBox_Fleet_Button_Remove_Click);
            // 
            // GroupBox_Fleet_Button_Modify
            // 
            this.GroupBox_Fleet_Button_Modify.Location = new System.Drawing.Point(6, 22);
            this.GroupBox_Fleet_Button_Modify.Name = "GroupBox_Fleet_Button_Modify";
            this.GroupBox_Fleet_Button_Modify.Size = new System.Drawing.Size(75, 23);
            this.GroupBox_Fleet_Button_Modify.TabIndex = 0;
            this.GroupBox_Fleet_Button_Modify.Text = "Modify";
            this.GroupBox_Fleet_Button_Modify.UseVisualStyleBackColor = true;
            this.GroupBox_Fleet_Button_Modify.Click += new System.EventHandler(this.GroupBox_Fleet_Button_Modify_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(409, -75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rego:";
            // 
            // DataGridView_Fleet
            // 
            this.DataGridView_Fleet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Fleet.Location = new System.Drawing.Point(3, 3);
            this.DataGridView_Fleet.Name = "DataGridView_Fleet";
            this.DataGridView_Fleet.RowTemplate.Height = 25;
            this.DataGridView_Fleet.Size = new System.Drawing.Size(786, 592);
            this.DataGridView_Fleet.TabIndex = 1;
            // 
            // CustomersTab
            // 
            this.CustomersTab.Controls.Add(this.GroupBox_Customers);
            this.CustomersTab.Controls.Add(this.GroupBox_Customers_Modify_Add);
            this.CustomersTab.Controls.Add(this.DataGridView_Customers);
            this.CustomersTab.Location = new System.Drawing.Point(4, 24);
            this.CustomersTab.Name = "CustomersTab";
            this.CustomersTab.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTab.Size = new System.Drawing.Size(792, 664);
            this.CustomersTab.TabIndex = 1;
            this.CustomersTab.Text = "Customers";
            this.CustomersTab.UseVisualStyleBackColor = true;
            // 
            // GroupBox_Customers
            // 
            this.GroupBox_Customers.Controls.Add(this.GroupBox_Customers_Button_Add);
            this.GroupBox_Customers.Controls.Add(this.GroupBox_Customers_Button_Remove);
            this.GroupBox_Customers.Controls.Add(this.GroupBox_Customers_Button_Modify);
            this.GroupBox_Customers.Controls.Add(this.label14);
            this.GroupBox_Customers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupBox_Customers.Location = new System.Drawing.Point(3, 606);
            this.GroupBox_Customers.Name = "GroupBox_Customers";
            this.GroupBox_Customers.Size = new System.Drawing.Size(786, 55);
            this.GroupBox_Customers.TabIndex = 6;
            this.GroupBox_Customers.TabStop = false;
            this.GroupBox_Customers.Text = "Modify Customer";
            // 
            // GroupBox_Customers_Button_Add
            // 
            this.GroupBox_Customers_Button_Add.Location = new System.Drawing.Point(695, 22);
            this.GroupBox_Customers_Button_Add.Name = "GroupBox_Customers_Button_Add";
            this.GroupBox_Customers_Button_Add.Size = new System.Drawing.Size(75, 23);
            this.GroupBox_Customers_Button_Add.TabIndex = 2;
            this.GroupBox_Customers_Button_Add.Text = "Add";
            this.GroupBox_Customers_Button_Add.UseVisualStyleBackColor = true;
            this.GroupBox_Customers_Button_Add.Click += new System.EventHandler(this.GroupBox_Customers_Button_Add_Click);
            // 
            // GroupBox_Customers_Button_Remove
            // 
            this.GroupBox_Customers_Button_Remove.Location = new System.Drawing.Point(87, 22);
            this.GroupBox_Customers_Button_Remove.Name = "GroupBox_Customers_Button_Remove";
            this.GroupBox_Customers_Button_Remove.Size = new System.Drawing.Size(75, 23);
            this.GroupBox_Customers_Button_Remove.TabIndex = 1;
            this.GroupBox_Customers_Button_Remove.Text = "Remove";
            this.GroupBox_Customers_Button_Remove.UseVisualStyleBackColor = true;
            this.GroupBox_Customers_Button_Remove.Click += new System.EventHandler(this.GroupBox_Customers_Button_Remove_Click);
            // 
            // GroupBox_Customers_Button_Modify
            // 
            this.GroupBox_Customers_Button_Modify.Location = new System.Drawing.Point(6, 22);
            this.GroupBox_Customers_Button_Modify.Name = "GroupBox_Customers_Button_Modify";
            this.GroupBox_Customers_Button_Modify.Size = new System.Drawing.Size(75, 23);
            this.GroupBox_Customers_Button_Modify.TabIndex = 0;
            this.GroupBox_Customers_Button_Modify.Text = "Modify";
            this.GroupBox_Customers_Button_Modify.UseVisualStyleBackColor = true;
            this.GroupBox_Customers_Button_Modify.Click += new System.EventHandler(this.GroupBox_Customers_Button_Modify_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(409, -75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 15);
            this.label14.TabIndex = 13;
            this.label14.Text = "Rego:";
            // 
            // GroupBox_Customers_Modify_Add
            // 
            this.GroupBox_Customers_Modify_Add.Controls.Add(this.GroupBox_Customers_Modify_Add_ComboBox_Gender);
            this.GroupBox_Customers_Modify_Add.Controls.Add(this.GroupBox_Customers_Modify_Add_Button_Cancel);
            this.GroupBox_Customers_Modify_Add.Controls.Add(this.GroupBox_Customers_Modify_Add_Button_Submit);
            this.GroupBox_Customers_Modify_Add.Controls.Add(this.GroupBox_Customers_Modify_Add_ComboBox_Title);
            this.GroupBox_Customers_Modify_Add.Controls.Add(this.GroupBox_Customers_Modify_Add_TextBox_DOB);
            this.GroupBox_Customers_Modify_Add.Controls.Add(this.Label_DOB);
            this.GroupBox_Customers_Modify_Add.Controls.Add(this.Label_Title);
            this.GroupBox_Customers_Modify_Add.Controls.Add(this.Label_Gender);
            this.GroupBox_Customers_Modify_Add.Controls.Add(this.GroupBox_Customers_Modify_Add_TextBox_FirstName);
            this.GroupBox_Customers_Modify_Add.Controls.Add(this.Label_FirstName);
            this.GroupBox_Customers_Modify_Add.Controls.Add(this.GroupBox_Customers_Modify_Add_TextBox_LastName);
            this.GroupBox_Customers_Modify_Add.Controls.Add(this.Label_LastName);
            this.GroupBox_Customers_Modify_Add.Controls.Add(this.Label_CustomerID);
            this.GroupBox_Customers_Modify_Add.Location = new System.Drawing.Point(3, 413);
            this.GroupBox_Customers_Modify_Add.Name = "GroupBox_Customers_Modify_Add";
            this.GroupBox_Customers_Modify_Add.Size = new System.Drawing.Size(786, 193);
            this.GroupBox_Customers_Modify_Add.TabIndex = 5;
            this.GroupBox_Customers_Modify_Add.TabStop = false;
            this.GroupBox_Customers_Modify_Add.Text = "groupBox1";
            this.GroupBox_Customers_Modify_Add.Visible = false;
            // 
            // GroupBox_Customers_Modify_Add_ComboBox_Gender
            // 
            this.GroupBox_Customers_Modify_Add_ComboBox_Gender.FormattingEnabled = true;
            this.GroupBox_Customers_Modify_Add_ComboBox_Gender.Location = new System.Drawing.Point(572, 93);
            this.GroupBox_Customers_Modify_Add_ComboBox_Gender.Name = "GroupBox_Customers_Modify_Add_ComboBox_Gender";
            this.GroupBox_Customers_Modify_Add_ComboBox_Gender.Size = new System.Drawing.Size(99, 23);
            this.GroupBox_Customers_Modify_Add_ComboBox_Gender.TabIndex = 6;
            // 
            // GroupBox_Customers_Modify_Add_Button_Cancel
            // 
            this.GroupBox_Customers_Modify_Add_Button_Cancel.Location = new System.Drawing.Point(703, 151);
            this.GroupBox_Customers_Modify_Add_Button_Cancel.Name = "GroupBox_Customers_Modify_Add_Button_Cancel";
            this.GroupBox_Customers_Modify_Add_Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.GroupBox_Customers_Modify_Add_Button_Cancel.TabIndex = 8;
            this.GroupBox_Customers_Modify_Add_Button_Cancel.Text = "Cancel";
            this.GroupBox_Customers_Modify_Add_Button_Cancel.UseVisualStyleBackColor = true;
            this.GroupBox_Customers_Modify_Add_Button_Cancel.Click += new System.EventHandler(this.GroupBox_Customers_Modify_Add_Button_Cancel_Click);
            // 
            // GroupBox_Customers_Modify_Add_Button_Submit
            // 
            this.GroupBox_Customers_Modify_Add_Button_Submit.Location = new System.Drawing.Point(622, 151);
            this.GroupBox_Customers_Modify_Add_Button_Submit.Name = "GroupBox_Customers_Modify_Add_Button_Submit";
            this.GroupBox_Customers_Modify_Add_Button_Submit.Size = new System.Drawing.Size(75, 23);
            this.GroupBox_Customers_Modify_Add_Button_Submit.TabIndex = 7;
            this.GroupBox_Customers_Modify_Add_Button_Submit.Text = "Submit";
            this.GroupBox_Customers_Modify_Add_Button_Submit.UseVisualStyleBackColor = true;
            this.GroupBox_Customers_Modify_Add_Button_Submit.Click += new System.EventHandler(this.GroupBox_Customers_Modify_Add_Button_Submit_Click);
            // 
            // GroupBox_Customers_Modify_Add_ComboBox_Title
            // 
            this.GroupBox_Customers_Modify_Add_ComboBox_Title.FormattingEnabled = true;
            this.GroupBox_Customers_Modify_Add_ComboBox_Title.Location = new System.Drawing.Point(110, 93);
            this.GroupBox_Customers_Modify_Add_ComboBox_Title.Name = "GroupBox_Customers_Modify_Add_ComboBox_Title";
            this.GroupBox_Customers_Modify_Add_ComboBox_Title.Size = new System.Drawing.Size(100, 23);
            this.GroupBox_Customers_Modify_Add_ComboBox_Title.TabIndex = 2;
            // 
            // GroupBox_Customers_Modify_Add_TextBox_DOB
            // 
            this.GroupBox_Customers_Modify_Add_TextBox_DOB.Location = new System.Drawing.Point(572, 56);
            this.GroupBox_Customers_Modify_Add_TextBox_DOB.Name = "GroupBox_Customers_Modify_Add_TextBox_DOB";
            this.GroupBox_Customers_Modify_Add_TextBox_DOB.Size = new System.Drawing.Size(99, 23);
            this.GroupBox_Customers_Modify_Add_TextBox_DOB.TabIndex = 5;
            // 
            // Label_DOB
            // 
            this.Label_DOB.AutoSize = true;
            this.Label_DOB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_DOB.Location = new System.Drawing.Point(530, 59);
            this.Label_DOB.Name = "Label_DOB";
            this.Label_DOB.Size = new System.Drawing.Size(36, 15);
            this.Label_DOB.TabIndex = 18;
            this.Label_DOB.Text = "DOB:";
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Title.Location = new System.Drawing.Point(69, 96);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(35, 15);
            this.Label_Title.TabIndex = 17;
            this.Label_Title.Text = "Title:";
            // 
            // Label_Gender
            // 
            this.Label_Gender.AutoSize = true;
            this.Label_Gender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Gender.Location = new System.Drawing.Point(514, 96);
            this.Label_Gender.Name = "Label_Gender";
            this.Label_Gender.Size = new System.Drawing.Size(52, 15);
            this.Label_Gender.TabIndex = 8;
            this.Label_Gender.Text = "Gender:";
            // 
            // GroupBox_Customers_Modify_Add_TextBox_FirstName
            // 
            this.GroupBox_Customers_Modify_Add_TextBox_FirstName.Location = new System.Drawing.Point(349, 56);
            this.GroupBox_Customers_Modify_Add_TextBox_FirstName.Name = "GroupBox_Customers_Modify_Add_TextBox_FirstName";
            this.GroupBox_Customers_Modify_Add_TextBox_FirstName.Size = new System.Drawing.Size(100, 23);
            this.GroupBox_Customers_Modify_Add_TextBox_FirstName.TabIndex = 3;
            // 
            // Label_FirstName
            // 
            this.Label_FirstName.AutoSize = true;
            this.Label_FirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_FirstName.Location = new System.Drawing.Point(273, 59);
            this.Label_FirstName.Name = "Label_FirstName";
            this.Label_FirstName.Size = new System.Drawing.Size(70, 15);
            this.Label_FirstName.TabIndex = 6;
            this.Label_FirstName.Text = "First Name:";
            // 
            // GroupBox_Customers_Modify_Add_TextBox_LastName
            // 
            this.GroupBox_Customers_Modify_Add_TextBox_LastName.Location = new System.Drawing.Point(349, 93);
            this.GroupBox_Customers_Modify_Add_TextBox_LastName.Name = "GroupBox_Customers_Modify_Add_TextBox_LastName";
            this.GroupBox_Customers_Modify_Add_TextBox_LastName.Size = new System.Drawing.Size(100, 23);
            this.GroupBox_Customers_Modify_Add_TextBox_LastName.TabIndex = 4;
            // 
            // Label_LastName
            // 
            this.Label_LastName.AutoSize = true;
            this.Label_LastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_LastName.Location = new System.Drawing.Point(275, 96);
            this.Label_LastName.Name = "Label_LastName";
            this.Label_LastName.Size = new System.Drawing.Size(68, 15);
            this.Label_LastName.TabIndex = 2;
            this.Label_LastName.Text = "Last Name:";
            // 
            // Label_CustomerID
            // 
            this.Label_CustomerID.AutoSize = true;
            this.Label_CustomerID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_CustomerID.Location = new System.Drawing.Point(27, 59);
            this.Label_CustomerID.Name = "Label_CustomerID";
            this.Label_CustomerID.Size = new System.Drawing.Size(77, 15);
            this.Label_CustomerID.TabIndex = 0;
            this.Label_CustomerID.Text = "CustomerID:";
            // 
            // DataGridView_Customers
            // 
            this.DataGridView_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Customers.Location = new System.Drawing.Point(3, 3);
            this.DataGridView_Customers.Name = "DataGridView_Customers";
            this.DataGridView_Customers.RowTemplate.Height = 25;
            this.DataGridView_Customers.Size = new System.Drawing.Size(786, 592);
            this.DataGridView_Customers.TabIndex = 0;
            // 
            // RentalReportTab
            // 
            this.RentalReportTab.Controls.Add(this.GroupBox_Report);
            this.RentalReportTab.Controls.Add(this.DataGridView_RentalReport);
            this.RentalReportTab.Location = new System.Drawing.Point(4, 24);
            this.RentalReportTab.Name = "RentalReportTab";
            this.RentalReportTab.Padding = new System.Windows.Forms.Padding(3);
            this.RentalReportTab.Size = new System.Drawing.Size(792, 664);
            this.RentalReportTab.TabIndex = 2;
            this.RentalReportTab.Text = "Rental Report";
            this.RentalReportTab.UseVisualStyleBackColor = true;
            // 
            // GroupBox_Report
            // 
            this.GroupBox_Report.Controls.Add(this.Label_TotalVehiclesRented);
            this.GroupBox_Report.Controls.Add(this.Label_TotalDailyRate);
            this.GroupBox_Report.Controls.Add(this.GroupBox_Report_Button_Return);
            this.GroupBox_Report.Controls.Add(this.label1);
            this.GroupBox_Report.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupBox_Report.Location = new System.Drawing.Point(3, 606);
            this.GroupBox_Report.Name = "GroupBox_Report";
            this.GroupBox_Report.Size = new System.Drawing.Size(786, 55);
            this.GroupBox_Report.TabIndex = 4;
            this.GroupBox_Report.TabStop = false;
            this.GroupBox_Report.Text = "Modify Rentals";
            // 
            // Label_TotalVehiclesRented
            // 
            this.Label_TotalVehiclesRented.AutoSize = true;
            this.Label_TotalVehiclesRented.Location = new System.Drawing.Point(535, 14);
            this.Label_TotalVehiclesRented.Name = "Label_TotalVehiclesRented";
            this.Label_TotalVehiclesRented.Size = new System.Drawing.Size(120, 15);
            this.Label_TotalVehiclesRented.TabIndex = 15;
            this.Label_TotalVehiclesRented.Text = "Total Vehicles Rented:";
            // 
            // Label_TotalDailyRate
            // 
            this.Label_TotalDailyRate.AutoSize = true;
            this.Label_TotalDailyRate.Location = new System.Drawing.Point(514, 34);
            this.Label_TotalDailyRate.Name = "Label_TotalDailyRate";
            this.Label_TotalDailyRate.Size = new System.Drawing.Size(141, 15);
            this.Label_TotalDailyRate.TabIndex = 14;
            this.Label_TotalDailyRate.Text = "Total Daily Rental Charge:";
            // 
            // GroupBox_Report_Button_Return
            // 
            this.GroupBox_Report_Button_Return.Location = new System.Drawing.Point(6, 22);
            this.GroupBox_Report_Button_Return.Name = "GroupBox_Report_Button_Return";
            this.GroupBox_Report_Button_Return.Size = new System.Drawing.Size(75, 23);
            this.GroupBox_Report_Button_Return.TabIndex = 0;
            this.GroupBox_Report_Button_Return.Text = "Return Vehicle";
            this.GroupBox_Report_Button_Return.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(409, -75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Rego:";
            // 
            // DataGridView_RentalReport
            // 
            this.DataGridView_RentalReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_RentalReport.Location = new System.Drawing.Point(3, 3);
            this.DataGridView_RentalReport.Name = "DataGridView_RentalReport";
            this.DataGridView_RentalReport.RowTemplate.Height = 25;
            this.DataGridView_RentalReport.Size = new System.Drawing.Size(786, 592);
            this.DataGridView_RentalReport.TabIndex = 3;
            // 
            // RentalSearchTab
            // 
            this.RentalSearchTab.Controls.Add(this.Label_DailyCostRangeMinus);
            this.RentalSearchTab.Controls.Add(this.Label_DailyCostRange);
            this.RentalSearchTab.Controls.Add(this.TextBox_Query);
            this.RentalSearchTab.Controls.Add(this.NumericUpDown_DailyCostRangeTop);
            this.RentalSearchTab.Controls.Add(this.NumericUpDown_DailyCostRangeBottom);
            this.RentalSearchTab.Controls.Add(this.Button_ShowAll);
            this.RentalSearchTab.Controls.Add(this.Button_Search);
            this.RentalSearchTab.Controls.Add(this.GroupBox_Results);
            this.RentalSearchTab.Location = new System.Drawing.Point(4, 24);
            this.RentalSearchTab.Name = "RentalSearchTab";
            this.RentalSearchTab.Padding = new System.Windows.Forms.Padding(3);
            this.RentalSearchTab.Size = new System.Drawing.Size(792, 664);
            this.RentalSearchTab.TabIndex = 3;
            this.RentalSearchTab.Text = "Rental Search";
            this.RentalSearchTab.UseVisualStyleBackColor = true;
            // 
            // Label_DailyCostRangeMinus
            // 
            this.Label_DailyCostRangeMinus.AutoSize = true;
            this.Label_DailyCostRangeMinus.Location = new System.Drawing.Point(186, 78);
            this.Label_DailyCostRangeMinus.Name = "Label_DailyCostRangeMinus";
            this.Label_DailyCostRangeMinus.Size = new System.Drawing.Size(12, 15);
            this.Label_DailyCostRangeMinus.TabIndex = 9;
            this.Label_DailyCostRangeMinus.Text = "-";
            // 
            // Label_DailyCostRange
            // 
            this.Label_DailyCostRange.AutoSize = true;
            this.Label_DailyCostRange.Location = new System.Drawing.Point(35, 78);
            this.Label_DailyCostRange.Name = "Label_DailyCostRange";
            this.Label_DailyCostRange.Size = new System.Drawing.Size(99, 15);
            this.Label_DailyCostRange.TabIndex = 8;
            this.Label_DailyCostRange.Text = "Daily Cost Range:";
            // 
            // TextBox_Query
            // 
            this.TextBox_Query.Location = new System.Drawing.Point(35, 19);
            this.TextBox_Query.Name = "TextBox_Query";
            this.TextBox_Query.Size = new System.Drawing.Size(304, 23);
            this.TextBox_Query.TabIndex = 1;
            this.TextBox_Query.Text = "Enter query here...";
            // 
            // NumericUpDown_DailyCostRangeTop
            // 
            this.NumericUpDown_DailyCostRangeTop.Location = new System.Drawing.Point(204, 76);
            this.NumericUpDown_DailyCostRangeTop.Name = "NumericUpDown_DailyCostRangeTop";
            this.NumericUpDown_DailyCostRangeTop.Size = new System.Drawing.Size(40, 23);
            this.NumericUpDown_DailyCostRangeTop.TabIndex = 5;
            // 
            // NumericUpDown_DailyCostRangeBottom
            // 
            this.NumericUpDown_DailyCostRangeBottom.Location = new System.Drawing.Point(140, 76);
            this.NumericUpDown_DailyCostRangeBottom.Name = "NumericUpDown_DailyCostRangeBottom";
            this.NumericUpDown_DailyCostRangeBottom.Size = new System.Drawing.Size(40, 23);
            this.NumericUpDown_DailyCostRangeBottom.TabIndex = 4;
            // 
            // Button_ShowAll
            // 
            this.Button_ShowAll.Location = new System.Drawing.Point(446, 19);
            this.Button_ShowAll.Name = "Button_ShowAll";
            this.Button_ShowAll.Size = new System.Drawing.Size(99, 35);
            this.Button_ShowAll.TabIndex = 3;
            this.Button_ShowAll.Text = "Show All";
            this.Button_ShowAll.UseVisualStyleBackColor = true;
            this.Button_ShowAll.Click += new System.EventHandler(this.Button_ShowAll_Click);
            // 
            // Button_Search
            // 
            this.Button_Search.Location = new System.Drawing.Point(341, 19);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(99, 35);
            this.Button_Search.TabIndex = 2;
            this.Button_Search.Text = "Search";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // GroupBox_Results
            // 
            this.GroupBox_Results.Controls.Add(this.GroupBox_CreateRental);
            this.GroupBox_Results.Controls.Add(this.DataGridView_RentalSearch);
            this.GroupBox_Results.Location = new System.Drawing.Point(18, 116);
            this.GroupBox_Results.Name = "GroupBox_Results";
            this.GroupBox_Results.Size = new System.Drawing.Size(755, 526);
            this.GroupBox_Results.TabIndex = 2;
            this.GroupBox_Results.TabStop = false;
            this.GroupBox_Results.Text = "Results";
            // 
            // GroupBox_CreateRental
            // 
            this.GroupBox_CreateRental.Controls.Add(this.Label_TotalCost);
            this.GroupBox_CreateRental.Controls.Add(this.Label_RentalDuration);
            this.GroupBox_CreateRental.Controls.Add(this.NumericUpDown_RentalDuration);
            this.GroupBox_CreateRental.Controls.Add(this.Button_Rent);
            this.GroupBox_CreateRental.Controls.Add(this.Label_Customer);
            this.GroupBox_CreateRental.Controls.Add(this.ComboBox_Customer);
            this.GroupBox_CreateRental.Location = new System.Drawing.Point(259, 411);
            this.GroupBox_CreateRental.Name = "GroupBox_CreateRental";
            this.GroupBox_CreateRental.Size = new System.Drawing.Size(479, 97);
            this.GroupBox_CreateRental.TabIndex = 2;
            this.GroupBox_CreateRental.TabStop = false;
            this.GroupBox_CreateRental.Text = "Create Rental";
            this.GroupBox_CreateRental.Enter += new System.EventHandler(this.GroupBox_CreateRental_Enter);
            // 
            // Label_TotalCost
            // 
            this.Label_TotalCost.AutoSize = true;
            this.Label_TotalCost.Location = new System.Drawing.Point(206, 66);
            this.Label_TotalCost.Name = "Label_TotalCost";
            this.Label_TotalCost.Size = new System.Drawing.Size(62, 15);
            this.Label_TotalCost.TabIndex = 4;
            this.Label_TotalCost.Text = "Total Cost:";
            // 
            // Label_RentalDuration
            // 
            this.Label_RentalDuration.AutoSize = true;
            this.Label_RentalDuration.Location = new System.Drawing.Point(13, 66);
            this.Label_RentalDuration.Name = "Label_RentalDuration";
            this.Label_RentalDuration.Size = new System.Drawing.Size(92, 15);
            this.Label_RentalDuration.TabIndex = 5;
            this.Label_RentalDuration.Text = "Rental Duration:";
            // 
            // NumericUpDown_RentalDuration
            // 
            this.NumericUpDown_RentalDuration.Location = new System.Drawing.Point(111, 64);
            this.NumericUpDown_RentalDuration.Name = "NumericUpDown_RentalDuration";
            this.NumericUpDown_RentalDuration.Size = new System.Drawing.Size(69, 23);
            this.NumericUpDown_RentalDuration.TabIndex = 7;
            this.NumericUpDown_RentalDuration.ValueChanged += new System.EventHandler(this.NumericUpDown_RentalDuration_ValueChanged);
            // 
            // Button_Rent
            // 
            this.Button_Rent.Location = new System.Drawing.Point(360, 34);
            this.Button_Rent.Name = "Button_Rent";
            this.Button_Rent.Size = new System.Drawing.Size(99, 35);
            this.Button_Rent.TabIndex = 8;
            this.Button_Rent.Text = "Rent";
            this.Button_Rent.UseVisualStyleBackColor = true;
            this.Button_Rent.Click += new System.EventHandler(this.Button_Rent_Click);
            // 
            // Label_Customer
            // 
            this.Label_Customer.AutoSize = true;
            this.Label_Customer.Location = new System.Drawing.Point(43, 23);
            this.Label_Customer.Name = "Label_Customer";
            this.Label_Customer.Size = new System.Drawing.Size(62, 15);
            this.Label_Customer.TabIndex = 3;
            this.Label_Customer.Text = "Customer:";
            // 
            // ComboBox_Customer
            // 
            this.ComboBox_Customer.FormattingEnabled = true;
            this.ComboBox_Customer.Location = new System.Drawing.Point(111, 20);
            this.ComboBox_Customer.Name = "ComboBox_Customer";
            this.ComboBox_Customer.Size = new System.Drawing.Size(185, 23);
            this.ComboBox_Customer.TabIndex = 6;
            // 
            // DataGridView_RentalSearch
            // 
            this.DataGridView_RentalSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_RentalSearch.Location = new System.Drawing.Point(17, 22);
            this.DataGridView_RentalSearch.Name = "DataGridView_RentalSearch";
            this.DataGridView_RentalSearch.RowTemplate.Height = 25;
            this.DataGridView_RentalSearch.Size = new System.Drawing.Size(721, 383);
            this.DataGridView_RentalSearch.TabIndex = 1;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 692);
            this.Controls.Add(this.TabControl_MainView);
            this.Name = "MainView";
            this.Text = "Car Rentals";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.TabControl_MainView.ResumeLayout(false);
            this.FleetTab.ResumeLayout(false);
            this.GroupBox_Fleet_Modify_Add.ResumeLayout(false);
            this.GroupBox_Fleet_Modify_Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox_Fleet_Modify_Add_NumericUpDown_DailyRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox_Fleet_Modify_Add_NumericUpDown_Seats)).EndInit();
            this.GroupBox_Fleet.ResumeLayout(false);
            this.GroupBox_Fleet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Fleet)).EndInit();
            this.CustomersTab.ResumeLayout(false);
            this.GroupBox_Customers.ResumeLayout(false);
            this.GroupBox_Customers.PerformLayout();
            this.GroupBox_Customers_Modify_Add.ResumeLayout(false);
            this.GroupBox_Customers_Modify_Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Customers)).EndInit();
            this.RentalReportTab.ResumeLayout(false);
            this.GroupBox_Report.ResumeLayout(false);
            this.GroupBox_Report.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_RentalReport)).EndInit();
            this.RentalSearchTab.ResumeLayout(false);
            this.RentalSearchTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_DailyCostRangeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_DailyCostRangeBottom)).EndInit();
            this.GroupBox_Results.ResumeLayout(false);
            this.GroupBox_CreateRental.ResumeLayout(false);
            this.GroupBox_CreateRental.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_RentalDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_RentalSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl_MainView;
        private System.Windows.Forms.TabPage FleetTab;
        private System.Windows.Forms.TabPage CustomersTab;
        private System.Windows.Forms.TabPage RentalReportTab;
        private System.Windows.Forms.TabPage RentalSearchTab;
        private System.Windows.Forms.DataGridView DataGridView_Fleet;
        private System.Windows.Forms.DataGridView DataGridView_Customers;
        private System.Windows.Forms.DataGridView DataGridView_RentalSearch;
        private System.Windows.Forms.GroupBox GroupBox_Fleet;
        private System.Windows.Forms.Button GroupBox_Fleet_Button_Add;
        private System.Windows.Forms.Button GroupBox_Fleet_Button_Remove;
        private System.Windows.Forms.Button GroupBox_Fleet_Button_Modify;
        private System.Windows.Forms.GroupBox GroupBox_Fleet_Modify_Add;
        private System.Windows.Forms.TextBox GroupBox_Fleet_Modify_Add_TextBox_Rego;
        private System.Windows.Forms.Label Label_Rego;
        private System.Windows.Forms.NumericUpDown GroupBox_Fleet_Modify_Add_NumericUpDown_DailyRate;
        private System.Windows.Forms.NumericUpDown GroupBox_Fleet_Modify_Add_NumericUpDown_Seats;
        private System.Windows.Forms.CheckBox GroupBox_Fleet_Modify_Add_CheckBox_GPS;
        private System.Windows.Forms.CheckBox GroupBox_Fleet_Modify_Add_CheckBox_Sunroof;
        private System.Windows.Forms.ComboBox GroupBox_Fleet_Modify_Add_ComboBox_Fuel;
        private System.Windows.Forms.ComboBox GroupBox_Fleet_Modify_Add_ComboBox_Class;
        private System.Windows.Forms.ComboBox GroupBox_Fleet_Modify_Add_ComboBox_Transmission;
        private System.Windows.Forms.Button GroupBox_Fleet_Modify_Add_Button_Cancel;
        private System.Windows.Forms.Button GroupBox_Fleet_Modify_Add_Button_Submit;
        private System.Windows.Forms.Label Label_GPS;
        private System.Windows.Forms.Label Label_Class;
        private System.Windows.Forms.Label Label_Transmission;
        private System.Windows.Forms.Label Label_Fuel;
        private System.Windows.Forms.Label Label_Seats;
        private System.Windows.Forms.Label Label_Sunroof;
        private System.Windows.Forms.Label Label_DailyRate;
        private System.Windows.Forms.TextBox GroupBox_Fleet_Modify_Add_TextBox_Colour;
        private System.Windows.Forms.Label Label_Colour;
        private System.Windows.Forms.TextBox GroupBox_Fleet_Modify_Add_TextBox_Year;
        private System.Windows.Forms.Label Label_Year;
        private System.Windows.Forms.TextBox GroupBox_Fleet_Modify_Add_TextBox_Make;
        private System.Windows.Forms.Label Label_Make;
        private System.Windows.Forms.TextBox GroupBox_Fleet_Modify_Add_TextBox_Model;
        private System.Windows.Forms.Label Label_Model;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox GroupBox_Customers;
        private System.Windows.Forms.Button GroupBox_Customers_Button_Add;
        private System.Windows.Forms.Button GroupBox_Customers_Button_Remove;
        private System.Windows.Forms.Button GroupBox_Customers_Button_Modify;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox GroupBox_Customers_Modify_Add;
        private System.Windows.Forms.ComboBox GroupBox_Customers_Modify_Add_ComboBox_Title;
        private System.Windows.Forms.Button GroupBox_Customers_Modify_Add_Button_Cancel;
        private System.Windows.Forms.Button GroupBox_Customers_Modify_Add_Button_Submit;
        private System.Windows.Forms.Label Label_DOB;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.TextBox GroupBox_Customers_Modify_Add_TextBox_DOB;
        private System.Windows.Forms.Label Label_Gender;
        private System.Windows.Forms.TextBox GroupBox_Customers_Modify_Add_TextBox_FirstName;
        private System.Windows.Forms.Label Label_FirstName;
        private System.Windows.Forms.TextBox GroupBox_Customers_Modify_Add_TextBox_LastName;
        private System.Windows.Forms.Label Label_LastName;
        private System.Windows.Forms.Label Label_CustomerID;
        private System.Windows.Forms.ComboBox GroupBox_Customers_Modify_Add_ComboBox_Gender;
        private System.Windows.Forms.TextBox GroupBox_;
        private System.Windows.Forms.TextBox Flee;
        private System.Windows.Forms.GroupBox GroupBox_Report;
        private System.Windows.Forms.Button GroupBox_Report_Button_Return;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridView_RentalReport;
        private System.Windows.Forms.Label Label_DailyCostRange;
        private System.Windows.Forms.TextBox TextBox_Query;
        private System.Windows.Forms.NumericUpDown NumericUpDown_DailyCostRangeTop;
        private System.Windows.Forms.NumericUpDown NumericUpDown_DailyCostRangeBottom;
        private System.Windows.Forms.Button Button_ShowAll;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.GroupBox GroupBox_Results;
        private System.Windows.Forms.Label Label_RentalDuration;
        private System.Windows.Forms.Label Label_TotalCost;
        private System.Windows.Forms.Label Label_Customer;
        private System.Windows.Forms.GroupBox GroupBox_CreateRental;
        private System.Windows.Forms.NumericUpDown NumericUpDown_RentalDuration;
        private System.Windows.Forms.Button Button_Rent;
        private System.Windows.Forms.ComboBox ComboBox_Customer;
        private System.Windows.Forms.Label Label_DailyCostRangeMinus;
        private System.Windows.Forms.Label Label_TotalVehiclesRented;
        private System.Windows.Forms.Label Label_TotalDailyRate;
    }
}

