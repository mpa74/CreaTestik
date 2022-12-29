using Testik.ViewModels;

namespace Testik.Views;

public partial class DrawPage : ContentPage
{
	public DrawPage()
	{
		InitializeComponent();

		BindingContext = new DrawPageViewModel();
	}
}
