namespace CadastroEventos.Views;

public partial class Concluido : ContentPage
{
	public Concluido()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new CadastroEventos());
    }
}