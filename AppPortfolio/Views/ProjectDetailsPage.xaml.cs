using AppPortfolio.ViewModels;

namespace AppPortfolio.Views;

public partial class ProjectDetailsPage : ContentPage
{
	public ProjectDetailsPage(ProjectDetailsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}