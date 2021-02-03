
namespace CarRentals
{
    partial class PopupConfirmationView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PopupConfirmation_Button_Cancel = new System.Windows.Forms.Button();
            this.PopupConfirmation_Button_Confirm = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PopupConfirmation_Button_Cancel
            // 
            this.PopupConfirmation_Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.PopupConfirmation_Button_Cancel.Location = new System.Drawing.Point(139, 74);
            this.PopupConfirmation_Button_Cancel.Name = "PopupConfirmation_Button_Cancel";
            this.PopupConfirmation_Button_Cancel.Size = new System.Drawing.Size(93, 38);
            this.PopupConfirmation_Button_Cancel.TabIndex = 2;
            this.PopupConfirmation_Button_Cancel.Text = "Cancel";
            this.PopupConfirmation_Button_Cancel.UseVisualStyleBackColor = true;
            this.PopupConfirmation_Button_Cancel.Click += new System.EventHandler(this.PopupConfirmation_Button_Cancel_Click);
            // 
            // PopupConfirmation_Button_Confirm
            // 
            this.PopupConfirmation_Button_Confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.PopupConfirmation_Button_Confirm.Location = new System.Drawing.Point(40, 74);
            this.PopupConfirmation_Button_Confirm.Name = "PopupConfirmation_Button_Confirm";
            this.PopupConfirmation_Button_Confirm.Size = new System.Drawing.Size(93, 38);
            this.PopupConfirmation_Button_Confirm.TabIndex = 1;
            this.PopupConfirmation_Button_Confirm.Text = "OK";
            this.PopupConfirmation_Button_Confirm.UseVisualStyleBackColor = true;
            this.PopupConfirmation_Button_Confirm.Click += new System.EventHandler(this.PopupConfirmation_Button_Confirm_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(41, 27);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(38, 15);
            this.Label.TabIndex = 3;
            this.Label.Text = "label1";
            // 
            // PopupConfirmationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 124);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.PopupConfirmation_Button_Confirm);
            this.Controls.Add(this.PopupConfirmation_Button_Cancel);
            this.Name = "PopupConfirmationView";
            this.Text = "PopupConfirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PopupConfirmation_Button_Cancel;
        private System.Windows.Forms.Button PopupConfirmation_Button_Confirm;
        private System.Windows.Forms.Label Label;
    }
}