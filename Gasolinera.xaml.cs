namespace Navegación5330038;

public partial class Gasolinera : ContentPage
{
	public Gasolinera()
	{
		InitializeComponent();
	}

    private void Calcular_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(galones.Text))
        {
            double gal, l;

            gal = Convert.ToDouble(galones.Text);

            l = gal * 3.78 / 1;

            precioL.Text = l.ToString("N2");
        }
        else
        {
            DisplayAlert("ERROR", "Introduzca el dato requerido", "OK");
        }
    }
}