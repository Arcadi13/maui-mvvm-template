using Microsoft.Extensions.DependencyInjection;

namespace MyApp.Mvvm;

public static class DependencyInjection
{
    public static void AddView<TView, TViewModel>(this IServiceCollection services, string? route = null)
    {
        services.AddTransient(typeof(TView));
        services.AddTransient(typeof(TViewModel));
        Routing.RegisterRoute(route ?? typeof(TView).Name, typeof(TView));
    }
}
