using Xamarin.Forms;
using App1_Mimica.Model;
using System.ComponentModel;

namespace App1_Mimica.ViewModel
{
    public class InicioViewModel : INotifyPropertyChanged
    {
        public Partida Partida { get; set; }
        public Command IniciarCommand { get; set; }

        public InicioViewModel()
        {
            IniciarCommand = new Command(IniciarJogo);
        }

        private void IniciarJogo()
        {
            Application.Current.MainPage = new View.Jogar();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
