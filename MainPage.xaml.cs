namespace Navegación5330038;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}


    private void Cambio_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Cambio());
    }

    private void Superficie_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Superficie());
    }

    private void Dinosaurio_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Dinosaurio());
    }

    private void Gasolinera_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Gasolinera());
    }

    private void Acerca_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new About());
    }
}

