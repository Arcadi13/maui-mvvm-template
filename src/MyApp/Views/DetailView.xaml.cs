using MyApp.ViewModels;

namespace MyApp.Views;

public partial class DetailView : ContentPage
{
	public DetailView(DetailViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;

    }
}