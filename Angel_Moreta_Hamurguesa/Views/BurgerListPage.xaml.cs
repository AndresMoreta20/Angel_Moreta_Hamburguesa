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

    }

    async void OnItemAdded(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(BurgerItemPage));
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