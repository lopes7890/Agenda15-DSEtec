namespace AppEventos.Views;

public partial class Confirmacao : ContentPage
{
	public Confirmacao()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
        try
        {
            Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "ok");

        }
    }
}