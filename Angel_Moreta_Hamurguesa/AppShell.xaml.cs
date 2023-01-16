using Angel_Moreta_Hamburguesa.Views;
using Angel_Moreta_Hamurguesa.Views;

namespace Angel_Moreta_Hamburguesa;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(BurgerItemPage), typeof(BurgerItemPage));
        Routing.RegisterRoute(nameof(BurgerListPage), typeof(BurgerListPage));
        Routing.RegisterRoute(nameof(EditBurgerItem), typeof(EditBurgerItem));
    }
}
