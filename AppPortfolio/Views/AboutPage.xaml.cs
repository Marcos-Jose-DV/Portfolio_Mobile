using AppPortfolio.ViewModels;

namespace AppPortfolio.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage(HomeViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}