using Angel_Moreta_Hamburguesa.Models;
using Angel_Moreta_Hamurguesa.Views;

namespace Angel_Moreta_Hamburguesa.Views;

public partial class BurgerListPage : ContentPage
{

/*
    public Burger selectedBurger
    {
        get => BindingContext as Burger;
        set => BindingContext = value;
    }*/
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

    public void OnItemSelected(object sender, SelectionChangedEventArgs e)
    {
        /*Burger selectedBurger = new Burger(); 
        selectedBurger.Name = (e.CurrentSelection as Burger)?.Name;
        selectedBurger.Id = (e.CurrentSelection as Burger).Id;
        selectedBurger.Description = (e.CurrentSelection as Burger)?.Description;
        selectedBurger.WithExtraCheese = (e.CurrentSelection as Burger).WithExtraCheese;
        */
        //Burger selectedBurger = e.CurrentSelection as Burger;
        Burger selectedBurger =  (Burger)burgerList.SelectedItem;
        if (selectedBurger != null)
        {
            // await Shell.Current.GoToAsync(nameof(EditBurgerItem));
            
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

