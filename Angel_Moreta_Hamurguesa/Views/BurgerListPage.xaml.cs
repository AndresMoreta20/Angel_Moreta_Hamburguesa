using Angel_Moreta_Hamburguesa.Models;
using Angel_Moreta_Hamurguesa.Views;

namespace Angel_Moreta_Hamburguesa.Views;

public partial class BurgerListPage : ContentPage
{
	public BurgerListPage()
	{
        InitializeComponent();
        List<Burger> burger = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = burger;        
        BindingContext = this;
    }

    public void OnItemAdded(object sender, EventArgs e)
    {
        // await Shell.Current.GoToAsync(nameof(BurgerItemPage));
        Shell.Current.GoToAsync(nameof(BurgerItemPage), true, new Dictionary<string, object>
        {
            ["Item"] = new Burger()
        });

    }

    private void OnItemFocused(object sender, FocusEventArgs e)
    {

    }

    private async void OnItemSelected(object sender, SelectionChangedEventArgs e)
    {
        Burger selectedBurger = e.CurrentSelection as Burger;

        
        if (selectedBurger != null)
        {
            await Shell.Current.GoToAsync(nameof(EditBurgerItem));
           
        }
    }
}