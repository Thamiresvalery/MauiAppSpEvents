
using MauiAppSpEvents.Models;

namespace MauiAppSpEvents
{
    public partial class App : Application
    {
        public List<Evento> lista_eventos = new List<Evento>
        {
            new Evento()
            {
                Descricao = "Bruno Mars",
                Local = "Estádio Morumbis",
                ValorDiariaMulher = 500.0,
                ValorDiariaHomem = 800.0
            },

            new Evento()
            {
                Descricao = "Simone Mendes",
                Local = "Villa Country",
                ValorDiariaMulher = 600.0,
                ValorDiariaHomem = 850.0
            },

            new Evento()
            {
                Descricao = "Linkin Park",
                Local = "Allianz Park",
                ValorDiariaMulher = 400.0,
                ValorDiariaHomem = 800.0
            },

            new Evento()
            {
                Descricao = "Anitta",
                Local = "Espaço Unimed",
                ValorDiariaMulher = 580.0,
                ValorDiariaHomem = 700.0
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoEvento());
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
