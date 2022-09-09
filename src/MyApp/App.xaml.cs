using MyApp.Helpers;

namespace MyApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        LocalizationResourceManager.Init();

        MainPage = new AppShell();
    }
}