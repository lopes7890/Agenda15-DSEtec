namespace AppEventos.Views;
using AppEventos.Models;

public partial class PaginaInicial : ContentPage
{
	public PaginaInicial()
	{
		InitializeComponent();
	}


    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            string text_valor_pessoa = valor_pessoa.Text;
            Evento h = new Evento
            {
                nomeEvento = txt_evento_name.Text,
                numeroParticipantes = Convert.ToInt32(participantes.Value),
                localEvento = txt_evento_local.Text,
                custoParticipante = Convert.ToInt32(text_valor_pessoa),
                DataCheckIn = dtpck_checkin.Date,
                DataCheckOut = dtpck_checkout.Date,

            };
            await Navigation.PushAsync(new Confirmacao()
            {
                BindingContext = h
            });
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }
    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = elemento.Date;

        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
    }


}



