using Angel_Moreta_Hamburguesa.Data;
namespace Angel_Moreta_Hamburguesa;

public partial class App : Application
{
    public static BurgerDatabase BurgerRepo { get; set; }

    public App(BurgerDatabase repo)
    {
        InitializeComponent();
        MainPage = new AppShell();
        BurgerRepo = repo;
    }

}
