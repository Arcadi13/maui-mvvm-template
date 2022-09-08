using MyApp.Mvvm;
using MyApp.Services;

namespace MyApp.ViewModels.Base;

public abstract class BaseViewModel : BindableBase, IQueryAttributable
{
    protected INavigationService NavigationService;

    public BaseViewModel(INavigationService navigationService)
    {
        NavigationService = navigationService;
    }

    protected IDictionary<string, object> Parameters { get; private set; }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        OnNavigated(query);
    }

    protected virtual Task OnNavigated(IDictionary<string, object> parameters)
    {
        return Task.CompletedTask;
    }
}
