namespace CadastroEventos.Views;

public partial class EventoContratado : ContentPage
{
	public EventoContratado()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Concluido());

        }catch (Exception ex)
        {
            DisplayAlert("ERRO", ex.Message, "OK");
        }

    }
		
    }
