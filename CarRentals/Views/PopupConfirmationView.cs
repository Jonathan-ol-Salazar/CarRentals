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
    }
}
