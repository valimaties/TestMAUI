using CommunityToolkit.Mvvm.ComponentModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMAUI.Models
{
    [ObservableObject]
    public partial class MyControlModel
    {
        [ObservableProperty]
        private string firstLineText;
        [ObservableProperty]
        private Image myImage;
        [ObservableProperty]
        private string myTitle;

        public MyControlModel(string firstLine, Image myImage, string myTitle)
        {
            FirstLineText = firstLine;
            MyImage = myImage;
            MyTitle = myTitle;
        }
    }
}
