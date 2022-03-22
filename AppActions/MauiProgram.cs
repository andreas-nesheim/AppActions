namespace AppActions;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureEssentials(e =>
			{
				e.AddAppAction(new AppAction("id1", "Messages", icon: "messages"));
				e.AddAppAction(new AppAction("id2", "Appointments", icon: "calendar"));
				e.AddAppAction(new AppAction("id3", "App Info", icon: "information"));
			})
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		return builder.Build();
	}
}
