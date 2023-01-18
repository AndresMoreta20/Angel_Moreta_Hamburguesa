using Angel_Moreta_Hamburguesa.Views;

namespace Angel_Moreta_Hamburguesa;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(AM_BurgerItemPage), typeof(AM_BurgerItemPage));
        Routing.RegisterRoute(nameof(AM_BurgerListPage), typeof(AM_BurgerListPage));
    }
}
