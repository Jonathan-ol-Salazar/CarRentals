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


        private void Button_Confirm_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Button_Cancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
