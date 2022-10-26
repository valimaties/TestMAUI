using CommunityToolkit.Mvvm.ComponentModel;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMAUI.ViewModels
{
    [ObservableObject]
    public partial class MainPageViewModel
    {
        [ObservableProperty]
        private ObservableCollection<MyControlViewModel> myControlModels = new();

        public MainPageViewModel()
        {
            MyControlModels.Add(new MyControlViewModel() { FirstLineText = "MC1", MyImage = "angry.jpg", MyTitle = "This is first control" });
            MyControlModels.Add(new MyControlViewModel() { FirstLineText = "MC2", MyImage = "person.jpg", MyTitle = "This is second control" });
            MyControlModels.Add(new MyControlViewModel() { FirstLineText = "MC3", MyImage = "thedarkbass.png", MyTitle = "This is third control, image problem" });
        }
    }
}
