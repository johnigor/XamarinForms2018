using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwitchPage : ContentPage
    {
        public SwitchPage()
        {
            InitializeComponent();
        }

        private void ActionChanged(object sender, ToggledEventArgs args)
        {
            Resultado.Text = DateTime.Now.ToString("HH:mm") + " - " + args.Value;
        }
    }
}