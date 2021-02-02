using CarRentals.Presenters;
using System.Windows.Forms;

namespace CarRentals.Views
{
    public partial class PopupConfirmationView : Form, IPopupConfirmationView
    {
        public PopupConfirmationView()
        {
            InitializeComponent();
        }


        public string LabelText { get { return Label.Text; } set { Label.Text = value; } }

        public Control Button_Confirm { get { return PopupConfirmation_Button_Confirm; } set { PopupConfirmation_Button_Confirm = (Button)value; } }
        public Control Button_Cancel { get { return PopupConfirmation_Button_Cancel; } set { PopupConfirmation_Button_Cancel = (Button)value; } }


        private void PopupConfirmation_Button_Confirm_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void PopupConfirmation_Button_Cancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
