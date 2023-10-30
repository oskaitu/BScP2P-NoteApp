
namespace Mini_Project_Note_App;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		remember.Text = "Stuff I\nshould\nremember";
		remember.TextColor = Colors.Black;
		

	}

    private async void OnGoToMyPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Hmm());
    }




}

