namespace Hotel.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Button_Clicked3(object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}