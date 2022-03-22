namespace AppActions;

public partial class ModalPage : ContentPage
{
	public ModalPage(string appActionTitle)
	{
		InitializeComponent();

		WelcomeLabel.Text = $"Opened the {appActionTitle} app action!";
	}
}

