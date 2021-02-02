using System.Windows.Forms;

namespace CarRentals.Views
{
    public interface IPopupConfirmationView
    {
        string LabelText { get; set; }
        Control Button_Confirm { get; set; }
        Control Button_Cancel { get; set; }

    }
}
