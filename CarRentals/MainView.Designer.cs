
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
            this.DataGridView_Fleet = new System.Windows.Forms.DataGridView();
            this.CustomersTab = new System.Windows.Forms.TabPage();
            this.DataGridView_Customers = new System.Windows.Forms.DataGridView();
            this.RentalReportTab = new System.Windows.Forms.TabPage();
            this.DataGridView_RentalReport = new System.Windows.Forms.DataGridView();
            this.RentalSearchTab = new System.Windows.Forms.TabPage();
            this.DataGridView_RentalSearch = new System.Windows.Forms.DataGridView();
            this.GroupBox_Fleet = new System.Windows.Forms.GroupBox();
            this.GroupBox_Fleet_Button_Modify = new System.Windows.Forms.Button();
            this.GroupBox_Fleet_Button_Remove = new System.Windows.Forms.Button();
            this.GroupBox_Fleet_Button_Add = new System.Windows.Forms.Button();
            this.TabControl_MainView.SuspendLayout();
            this.FleetTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Fleet)).BeginInit();
            this.CustomersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Customers)).BeginInit();
            this.RentalReportTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_RentalReport)).BeginInit();
            this.RentalSearchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_RentalSearch)).BeginInit();
            this.GroupBox_Fleet.SuspendLayout();
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
            this.TabControl_MainView.Size = new System.Drawing.Size(800, 450);
            this.TabControl_MainView.TabIndex = 0;
            // 
            // FleetTab
            // 
            this.FleetTab.Controls.Add(this.GroupBox_Fleet);
            this.FleetTab.Controls.Add(this.DataGridView_Fleet);
            this.FleetTab.Location = new System.Drawing.Point(4, 24);
            this.FleetTab.Name = "FleetTab";
            this.FleetTab.Padding = new System.Windows.Forms.Padding(3);
            this.FleetTab.Size = new System.Drawing.Size(792, 422);
            this.FleetTab.TabIndex = 0;
            this.FleetTab.Text = "Fleet";
            this.FleetTab.UseVisualStyleBackColor = true;
            // 
            // DataGridView_Fleet
            // 
            this.DataGridView_Fleet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Fleet.Location = new System.Drawing.Point(3, 3);
            this.DataGridView_Fleet.Name = "DataGridView_Fleet";
            this.DataGridView_Fleet.RowTemplate.Height = 25;
            this.DataGridView_Fleet.Size = new System.Drawing.Size(786, 350);
            this.DataGridView_Fleet.TabIndex = 1;
            this.DataGridView_Fleet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CustomersTab
            // 
            this.CustomersTab.Controls.Add(this.DataGridView_Customers);
            this.CustomersTab.Location = new System.Drawing.Point(4, 24);
            this.CustomersTab.Name = "CustomersTab";
            this.CustomersTab.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTab.Size = new System.Drawing.Size(792, 422);
            this.CustomersTab.TabIndex = 1;
            this.CustomersTab.Text = "Customers";
            this.CustomersTab.UseVisualStyleBackColor = true;
            // 
            // DataGridView_Customers
            // 
            this.DataGridView_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_Customers.Location = new System.Drawing.Point(3, 3);
            this.DataGridView_Customers.Name = "DataGridView_Customers";
            this.DataGridView_Customers.RowTemplate.Height = 25;
            this.DataGridView_Customers.Size = new System.Drawing.Size(786, 416);
            this.DataGridView_Customers.TabIndex = 0;
            // 
            // RentalReportTab
            // 
            this.RentalReportTab.Controls.Add(this.DataGridView_RentalReport);
            this.RentalReportTab.Location = new System.Drawing.Point(4, 24);
            this.RentalReportTab.Name = "RentalReportTab";
            this.RentalReportTab.Padding = new System.Windows.Forms.Padding(3);
            this.RentalReportTab.Size = new System.Drawing.Size(792, 422);
            this.RentalReportTab.TabIndex = 2;
            this.RentalReportTab.Text = "Rental Report";
            this.RentalReportTab.UseVisualStyleBackColor = true;
            // 
            // DataGridView_RentalReport
            // 
            this.DataGridView_RentalReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_RentalReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_RentalReport.Location = new System.Drawing.Point(3, 3);
            this.DataGridView_RentalReport.Name = "DataGridView_RentalReport";
            this.DataGridView_RentalReport.RowTemplate.Height = 25;
            this.DataGridView_RentalReport.Size = new System.Drawing.Size(786, 416);
            this.DataGridView_RentalReport.TabIndex = 1;
            // 
            // RentalSearchTab
            // 
            this.RentalSearchTab.Controls.Add(this.DataGridView_RentalSearch);
            this.RentalSearchTab.Location = new System.Drawing.Point(4, 24);
            this.RentalSearchTab.Name = "RentalSearchTab";
            this.RentalSearchTab.Padding = new System.Windows.Forms.Padding(3);
            this.RentalSearchTab.Size = new System.Drawing.Size(792, 422);
            this.RentalSearchTab.TabIndex = 3;
            this.RentalSearchTab.Text = "Rental Search";
            this.RentalSearchTab.UseVisualStyleBackColor = true;
            // 
            // DataGridView_RentalSearch
            // 
            this.DataGridView_RentalSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_RentalSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_RentalSearch.Location = new System.Drawing.Point(3, 3);
            this.DataGridView_RentalSearch.Name = "DataGridView_RentalSearch";
            this.DataGridView_RentalSearch.RowTemplate.Height = 25;
            this.DataGridView_RentalSearch.Size = new System.Drawing.Size(786, 416);
            this.DataGridView_RentalSearch.TabIndex = 1;
            // 
            // GroupBox_Fleet
            // 
            this.GroupBox_Fleet.Controls.Add(this.GroupBox_Fleet_Button_Add);
            this.GroupBox_Fleet.Controls.Add(this.GroupBox_Fleet_Button_Remove);
            this.GroupBox_Fleet.Controls.Add(this.GroupBox_Fleet_Button_Modify);
            this.GroupBox_Fleet.Location = new System.Drawing.Point(8, 359);
            this.GroupBox_Fleet.Name = "GroupBox_Fleet";
            this.GroupBox_Fleet.Size = new System.Drawing.Size(776, 55);
            this.GroupBox_Fleet.TabIndex = 2;
            this.GroupBox_Fleet.TabStop = false;
            this.GroupBox_Fleet.Text = "Modify Fleet";
            // 
            // GroupBox_Fleet_Button_Modify
            // 
            this.GroupBox_Fleet_Button_Modify.Location = new System.Drawing.Point(6, 22);
            this.GroupBox_Fleet_Button_Modify.Name = "GroupBox_Fleet_Button_Modify";
            this.GroupBox_Fleet_Button_Modify.Size = new System.Drawing.Size(75, 23);
            this.GroupBox_Fleet_Button_Modify.TabIndex = 0;
            this.GroupBox_Fleet_Button_Modify.Text = "Modify";
            this.GroupBox_Fleet_Button_Modify.UseVisualStyleBackColor = true;
            // 
            // GroupBox_Fleet_Button_Remove
            // 
            this.GroupBox_Fleet_Button_Remove.Location = new System.Drawing.Point(87, 22);
            this.GroupBox_Fleet_Button_Remove.Name = "GroupBox_Fleet_Button_Remove";
            this.GroupBox_Fleet_Button_Remove.Size = new System.Drawing.Size(75, 23);
            this.GroupBox_Fleet_Button_Remove.TabIndex = 1;
            this.GroupBox_Fleet_Button_Remove.Text = "Remove";
            this.GroupBox_Fleet_Button_Remove.UseVisualStyleBackColor = true;
            // 
            // GroupBox_Fleet_Button_Add
            // 
            this.GroupBox_Fleet_Button_Add.Location = new System.Drawing.Point(695, 22);
            this.GroupBox_Fleet_Button_Add.Name = "GroupBox_Fleet_Button_Add";
            this.GroupBox_Fleet_Button_Add.Size = new System.Drawing.Size(75, 23);
            this.GroupBox_Fleet_Button_Add.TabIndex = 2;
            this.GroupBox_Fleet_Button_Add.Text = "Add";
            this.GroupBox_Fleet_Button_Add.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl_MainView);
            this.Name = "MainView";
            this.Text = "Car Rentals";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.TabControl_MainView.ResumeLayout(false);
            this.FleetTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Fleet)).EndInit();
            this.CustomersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Customers)).EndInit();
            this.RentalReportTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_RentalReport)).EndInit();
            this.RentalSearchTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_RentalSearch)).EndInit();
            this.GroupBox_Fleet.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView DataGridView_RentalReport;
        private System.Windows.Forms.DataGridView DataGridView_RentalSearch;
        private System.Windows.Forms.GroupBox GroupBox_Fleet;
        private System.Windows.Forms.Button GroupBox_Fleet_Button_Add;
        private System.Windows.Forms.Button GroupBox_Fleet_Button_Remove;
        private System.Windows.Forms.Button GroupBox_Fleet_Button_Modify;
    }
}

