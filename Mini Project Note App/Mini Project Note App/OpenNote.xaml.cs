namespace Mini_Project_Note_App;

public partial class OpenNote : ContentPage
{
	public OpenNote()
	{
		InitializeComponent();
	}
    private async void GoBackToHmm(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Hmm());
    }
}