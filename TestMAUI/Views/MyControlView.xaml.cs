using CommunityToolkit.Mvvm.Input;

using TestMAUI.ViewModels;

namespace TestMAUI.Views;

public partial class MyControlView : ContentView
{
	public MyControlView()
	{
		InitializeComponent();
        BindingContext = new MyControlViewModel();
    }
}