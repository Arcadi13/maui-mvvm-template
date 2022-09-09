using MyApp.Helpers;

namespace MyApp.Extensions;

[ContentProperty(nameof(Text))]
public class TranslateExtension : IMarkupExtension
{
    private readonly LocalizationResourceManager _localization;

    public TranslateExtension()
    {
        _localization = LocalizationResourceManager.Instance;
    }

    public string Text { get; set; }

    public object ProvideValue(IServiceProvider serviceProvider)
    {
        return _localization.GetValue(Text) ?? Text;    
    }

    object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider) => ProvideValue(serviceProvider);

}
