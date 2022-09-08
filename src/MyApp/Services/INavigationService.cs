namespace MyApp.Services;

public interface INavigationService
{
    Task GoToAsync(string route, Dictionary<string, object> parameters = null);
}