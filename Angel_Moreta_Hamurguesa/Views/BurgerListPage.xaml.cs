using Angel_Moreta_Hamburguesa.Models;
namespace Angel_Moreta_Hamburguesa.Views;

public partial class BurgerListPage : ContentPage
{

    public BurgerListPage()
    {
        InitializeComponent();
        List<Burger> burger = App.BurgerRepo.GetAllBurgers();
        AM_burgerList.ItemsSource = burger;
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

    public void OnItemSelected(object sender, SelectionChangedEventArgs e)
    {
        Burger selectedBurger =  (Burger)AM_burgerList.SelectedItem;
        if (selectedBurger != null)
        {            
            Shell.Current.GoToAsync(nameof(BurgerItemPage), true, new Dictionary<string, object>
            {
                ["Item"] = selectedBurger
            });

        } else
        {
            Console.WriteLine("error");
        }
    }

}

