using Angel_Moreta_Hamburguesa.Models;

namespace Angel_Moreta_Hamurguesa.Views;

public partial class EditBurgerItem : ContentPage
{
	public EditBurgerItem(Burger burger)
	{
		InitializeComponent();
		nameB.Text= burger.Name;
		descB.Text= burger.Description;
	}

    private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
    {

    }

    private void OnSaveClicked(object sender, EventArgs e)
    {

    }

    private void OnCancelClicked(object sender, EventArgs e)
    {

    }
}