using MyApp.Services;
using MyApp.ViewModels.Base;
using MyApp.Views;
using System.Windows.Input;

namespace MyApp.ViewModels;

public class HomeViewModel : BaseViewModel
{
    public HomeViewModel(INavigationService navigationService) : base(navigationService)
    {
        ClickedCommand = new Command(async () => await Clicked());
    }

    public ICommand ClickedCommand { get; }

    private async Task Clicked()
    {
        var parameters = new Dictionary<string, object>
        {
            {"key", 3 }
        };

       await NavigationService.GoToAsync(nameof(DetailView), parameters);
    }
}

