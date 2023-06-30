namespace Navegación5330038;

public partial class Superficie : ContentPage
{
	public Superficie()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(h.Text) || (!string.IsNullOrEmpty(b.Text)))
        {
            double altura, bas, superfic;

            altura = Convert.ToDouble(h.Text);
            bas = Convert.ToDouble(b.Text);

            superfic = (bas * altura) / 2;

            superficie.Text = superfic.ToString();
        }
        else
        {
            DisplayAlert("ERROR", "Ocurrio un error al introducir datos", "OK");
        }

    }
}