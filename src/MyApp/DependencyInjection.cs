using MyApp.Mvvm;
using MyApp.Services;
using MyApp.ViewModels;
using MyApp.Views;

namespace MyApp;
public static class DependencyInjection
{
    public static IServiceCollection AddPresentation (this IServiceCollection services)
    {
        services.AddSingleton<INavigationService, NavigationService>();

        services.AddView<HomeView, HomeViewModel>();
        services.AddView<DetailView, DetailViewModel>();
        return services;
    }
}
