using CommunityToolkit.Mvvm.ComponentModel;
using TestMAUI.Models;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;

namespace TestMAUI.ViewModels
{
    public partial class MyControlViewModel : ObservableObject
    {
        [ObservableProperty]
        private string firstLineText;
        [ObservableProperty]
        private string myImage;
        [ObservableProperty]
        private string myTitle;
        [ObservableProperty]
        private bool isClicked;

        public MyControlViewModel()
        {            
        }

        [RelayCommand]
        void ClickOnMe()
        {
            IsClicked = true;
        }
    }
}
