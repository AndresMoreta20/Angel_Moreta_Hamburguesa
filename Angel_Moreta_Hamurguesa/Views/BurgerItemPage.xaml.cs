using Angel_Moreta_Hamburguesa.Models;
using Angel_Moreta_Hamburguesa.Data;
namespace Angel_Moreta_Hamburguesa.Views;

[QueryProperty("Item", "Item")]
public partial class BurgerItemPage : ContentPage
{

    public Burger Item
    {
        get => BindingContext as Burger;
        set => BindingContext = value;
    }
    //Burger Item = new Burger();
    bool _flag = false;
	public BurgerItemPage()
	{
		InitializeComponent();
	}
  

    private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        _flag = e.Value;
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        /* Item.Name = nameB.Text;
         Item.Description = descB.Text;
         Item.WithExtraCheese = _flag;
         App.BurgerRepo.AddNewBurger(Item);*/
        //Shell.Current.GoToAsync("..");
        App.BurgerRepo.AddNewBurger(Item);
        await Shell.Current.GoToAsync(nameof(BurgerListPage));

    }

    private void OnCancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {

    }
}