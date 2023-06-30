namespace Navegación5330038;

public partial class Dinosaurio : ContentPage
{
	public Dinosaurio()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {

        if (!string.IsNullOrEmpty(peso.Text) || (!string.IsNullOrEmpty(altura.Text) || (!string.IsNullOrEmpty(nombre.Text))))
        {
            double pesokg, alturamts, pesoLi, alturacms;
            pesokg = Convert.ToDouble(peso.Text);
            alturamts = Convert.ToDouble(altura.Text);

            pesoLi = pesokg * 2.2046 / 1;
            alturacms = alturamts * 100 / 1;
            
            pesoL.Text = pesoLi.ToString();
            Alturacm.Text = alturacms.ToString();
        }
        else
        {
            DisplayAlert("Error", "Introduce los datos requeridos", "OK");

        }

    }
}