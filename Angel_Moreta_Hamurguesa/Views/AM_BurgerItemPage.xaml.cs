using Angel_Moreta_Hamburguesa.Models;
using Angel_Moreta_Hamburguesa.Data;
namespace Angel_Moreta_Hamburguesa.Views;

[QueryProperty("Item", "Item")]
public partial class AM_BurgerItemPage : ContentPage
{

    public Burger Item
    {
        get => BindingContext as Burger;
        set => BindingContext = value;
    }

    bool _flag = false;
	public AM_BurgerItemPage()
	{
		InitializeComponent();
	}
  

    private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        _flag = e.Value;
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        
        App.BurgerRepo.AddNewBurger(Item);
        await Shell.Current.GoToAsync(nameof(AM_BurgerListPage));

        /* Item.Name = nameB.Text;
         Item.Description = descB.Text;
         Item.WithExtraCheese = _flag;
         App.BurgerRepo.AddNewBurger(Item);*/
        //Shell.Current.GoToAsync("..");

    }

    private void OnCancelClicked(object sender, EventArgs e)
    {
        //Shell.Current.GoToAsync("..");
        Shell.Current.GoToAsync(nameof(AM_BurgerListPage));
    }

    private void OnDeleteClicked(object sender, EventArgs e)
    {
        App.BurgerRepo.DeleteBurger(Item);
        Shell.Current.GoToAsync(nameof(AM_BurgerListPage));
    }
}