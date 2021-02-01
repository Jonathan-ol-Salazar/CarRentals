
namespace CarRentals.Views
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
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Confirm = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_Cancel.Location = new System.Drawing.Point(139, 74);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(93, 38);
            this.Button_Cancel.TabIndex = 2;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            // 
            // Button_Confirm
            // 
            this.Button_Confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_Confirm.Location = new System.Drawing.Point(40, 74);
            this.Button_Confirm.Name = "Button_Confirm";
            this.Button_Confirm.Size = new System.Drawing.Size(93, 38);
            this.Button_Confirm.TabIndex = 1;
            this.Button_Confirm.Text = "Confirm";
            this.Button_Confirm.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.Button_Confirm);
            this.Controls.Add(this.Button_Cancel);
            this.Name = "PopupConfirmationView";
            this.Text = "PopupConfirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PopupConfirmation_Button_Cancel;
        private System.Windows.Forms.Button Button_Confirm;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button Button_Cancel;
    }
}