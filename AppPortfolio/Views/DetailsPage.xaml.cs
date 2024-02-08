using AppPortfolio.ViewModels;

namespace AppPortfolio.Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(DetailsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}