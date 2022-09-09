using System.Globalization;
using System.Resources;
using MyApp.Mvvm;
using MyApp.Resources.Translations;

namespace MyApp.Helpers;

public class LocalizationResourceManager : BindableBase
{
    private readonly ResourceManager _resourceManager;

    private CultureInfo _currentCulture;

    public static LocalizationResourceManager Instance;

    public LocalizationResourceManager(ResourceManager resourceManager)
    {
        _resourceManager = resourceManager;
        CurrentCulture = CultureInfo.CurrentCulture;  
    }

    public static void Init()
    {
        Instance = new LocalizationResourceManager(Translations.ResourceManager);
    }

    public CultureInfo CurrentCulture
    {
        get => _currentCulture;
        set => SetProperty(ref _currentCulture, value);
    }

    public string GetValue(string text)
    {
        return _resourceManager.GetString(text, CurrentCulture);
    }
}
