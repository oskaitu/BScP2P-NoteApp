namespace Mini_Project_Note_App;

public partial class NewNote : ContentPage
{
	public NewNote()
	{
		InitializeComponent();
	}
    private async void GoBackToHmm(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Hmm());
    }
}