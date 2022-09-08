using MyApp.Services;
using MyApp.ViewModels.Base;
using System.Windows.Input;

namespace MyApp.ViewModels;

public class DetailViewModel : BaseViewModel
{
    private int _count = 0;

    private string _text = "Click me";

    public DetailViewModel(INavigationService navigationService) : base(navigationService)
    {
        ClickedCommand = new Command(Clicked);
    }

    public string Text
    {
        get => _text;
        set => SetProperty(ref _text, value);
    }

    public ICommand ClickedCommand { get; }

    protected override async Task OnNavigated(IDictionary<string, object> parameters)
    {
        await Task.Delay(1000);

        _count = (int)parameters["key"];
        Text = $"Clicked {_count} times";
    }

    private void Clicked()
    {
        _count++;

        if (_count == 1)
            Text = $"Clicked {_count} time";
        else
            Text = $"Clicked {_count} times";
    }
}
