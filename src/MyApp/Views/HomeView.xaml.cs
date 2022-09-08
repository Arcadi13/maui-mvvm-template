using MyApp.ViewModels;

namespace MyApp.Views;

public partial class HomeView : ContentPage
{
	public HomeView(HomeViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}