namespace AppActions;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		
		Microsoft.Maui.Essentials.AppActions.OnAppAction += AppActions_OnAppAction;

		MainPage = new MainPage();
	}

    private void AppActions_OnAppAction(object sender, AppActionEventArgs e)
    {
        // Don't handle events fired for old application instances
        // and cleanup the old instance's event handler
        if (Application.Current != this && Application.Current is App app)
        {
            Microsoft.Maui.Essentials.AppActions.OnAppAction -= app.AppActions_OnAppAction;
            return;
        }
        MainThread.BeginInvokeOnMainThread(async () =>
        {
            var appActionId = e.AppAction.Id;
            var navigation = Current.MainPage.Navigation;
            await navigation.PushModalAsync(new ModalPage(e.AppAction.Title));
        });
    }
}
