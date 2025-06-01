

using CadastroEventos.Models;


namespace CadastroEventos.Views;

public partial class CadastroEventos : ContentPage
{
    App PropriedadesApp;
	public CadastroEventos()
	{
		InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_local.ItemsSource = PropriedadesApp.lista_local;

        pck_data.MinimumDate = DateTime.Now;
        pck_data.MaximumDate = pck_data.Date.AddMonths(6);

	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {

            Contratacao c = new Contratacao
            {
               EnderecoSelecionado = (Local)pck_local.SelectedItem,
               Evento = nome_evento.Text,
               QttAdultos = Convert.ToInt32(stp_adultos.Value),
               Qttcrianca = Convert.ToInt32(stp_criancas.Value),
               DataSelecionada = pck_data.Date,
               HrInicioSelecionada = hora_inicio.Time,
               HrFinalSelecionada = hora_final.Time,
            };

            await Navigation.PushAsync(new EventoContratado()
            {
                BindingContext = c,
            });
        }
        catch(Exception ex)
        {
           await DisplayAlert("ERRO", ex.Message, "OK");
        }
    }

    private void pck_data_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker element = sender as DatePicker;

        DateTime data_selecionada = element.Date;
        pck_data.MaximumDate = data_selecionada.AddMonths(6);
    }
}