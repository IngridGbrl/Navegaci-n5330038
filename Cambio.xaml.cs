namespace Navegación5330038;

public partial class Cambio : ContentPage
{
	public Cambio()
	{
		InitializeComponent();
	}

    private void Calcular_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Costo.Text) || (!string.IsNullOrEmpty(Dinero.Text)))
        {
            int CostoA, dinero, cambio;

            CostoA = Convert.ToInt32(Costo.Text);

            dinero = Convert.ToInt32(Dinero.Text);

            cambio = dinero - CostoA;

            Ccambio.Text = cambio.ToString();

        }
        else
        {
            DisplayAlert("ERROR", "Inserte datos", "OK");
        }
    }
}