using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();
            //ImageOne.IsLoading;

            Image image = new Image
            {
                Source = Device.RuntimePlatform == Device.UWP
                ? ImageSource.FromFile("Images/usb.png")
                : ImageSource.FromFile("usb.jpg")
            };

            Container.Children.Add(image);
        }
    }
}
