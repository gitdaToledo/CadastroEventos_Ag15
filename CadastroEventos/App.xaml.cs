using CadastroEventos.Models;

namespace CadastroEventos
{
    public partial class App : Application
    {
        public List<Local> lista_local = new List<Local>
        { 
            new Local()
        {
            Descricao = "Pitangueras, Guarujá",
            ValorAdultos= 300.0,
            Valorcrianca = 2500.0
        },
           new Local()
           {
            Descricao = "Jardins, São Paulo",
            ValorAdultos= 400.0,
            Valorcrianca = 350.0
           },
           new Local()
            {
            Descricao = "Copacabana, Rio de Janeiro",
            ValorAdultos= 500.0,
            Valorcrianca = 450.0
           }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.CadastroEventos());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;

        }
    }
}