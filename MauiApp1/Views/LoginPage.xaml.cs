using MauiApp1.ModelViews;

namespace MauiApp1.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginModelView loginModelView)
	{
		InitializeComponent();
		BindingContext = loginModelView;
	}
}
