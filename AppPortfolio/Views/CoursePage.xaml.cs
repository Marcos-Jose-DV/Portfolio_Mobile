using AppPortfolio.ViewModels;

namespace AppPortfolio.Views;

public partial class CoursePage : ContentPage
{
	public CoursePage(CourseViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}