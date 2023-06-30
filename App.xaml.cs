namespace Navegación5330038;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();


        MainPage = new NavigationPage(new MainPage());
    }
}
