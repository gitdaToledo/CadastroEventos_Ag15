namespace CadastroEventos.Views;

public partial class CadastroEventos : ContentPage
{
    App PropriedadesApp;
	public CadastroEventos()
	{
		InitializeComponent();

        PropriedadesApp = (App)Application.Current;

       //nao ta achando pck_local 
       //video ag14 min 28:50
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new EventoContratado());
        }
        catch(Exception ex)
        {
            DisplayAlert("ERRO", ex.Message, "OK");
        }
    }

    private void nome_evento_Completed(object sender, EventArgs e)
    {
        var entry = sender as Entry;
        string texto = entry?.Text;
        
    }

}