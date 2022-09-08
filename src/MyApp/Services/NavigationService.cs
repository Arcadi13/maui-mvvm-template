namespace MyApp.Services;

public class NavigationService : INavigationService
{
    public async Task GoToAsync(string route, Dictionary<string, object> parameters)
    {
        if (parameters is null)
        {
            await Shell.Current.GoToAsync(route);
            return;
        }

        await Shell.Current.GoToAsync(route, parameters);
    }
}
