namespace Mini_Project_Note_App;

public partial class Hmm : ContentPage
{
	public Hmm()
	{
		InitializeComponent();
	}

    private async void GoToOpenNote(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OpenNote());
    }

    private async void GoBackToMainPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    private async void GoBackToNewNote(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewNote());
    }
}