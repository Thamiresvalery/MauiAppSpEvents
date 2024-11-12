using MauiAppSpEvents.Models;

namespace MauiAppSpEvents.Views;

public partial class ContratacaoEvento : ContentPage
{

	App PropriedadesApp;
	public ContratacaoEvento()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		pck_evento.ItemsSource = PropriedadesApp.lista_eventos;

		dtpck_checkin.MinimumDate = DateTime.Now;
		dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month +1, DateTime.Now.Day);

		dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
		dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(2);

	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Hospedagem h = new Hospedagem
			{
				ShowSelecionado = (Evento)pck_evento.SelectedItem,
				LocalEvento = (Evento)pck_evento.SelectedItem,
				QntMulher = Convert.ToInt32(stp_mulher.Value),
				QntHomem = Convert.ToInt32(stp_homem.Value),
				DataCheckin = dtpck_checkin.Date,
				DataCheckout = dtpck_checkout.Date,
			};

			await Navigation.PushAsync(new EventoContratado()
			{
				BindingContext = h
			});

		} catch (Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "OK");
		}

    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento = sender as DatePicker;

		DateTime data_selecionada_checkin = elemento.Date;

		dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
		dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(2);
    }
}