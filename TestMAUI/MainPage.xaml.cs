using CommunityToolkit.Mvvm.ComponentModel;

using System.Collections.ObjectModel;

using TestMAUI.Models;
using TestMAUI.ViewModels;

namespace TestMAUI;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
        BindingContext = new MainPageViewModel();
    }
}

