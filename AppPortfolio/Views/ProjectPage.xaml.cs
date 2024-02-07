using AppPortfolio.ViewModels;

namespace AppPortfolio.Views;

public partial class ProjectPage : ContentPage
{
	public ProjectPage(ProjectViewModels vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}