using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace App1_Mimica.ViewModel
{
    public class JogoViewModel : INotifyPropertyChanged
    {
        private byte _palavraPontuacao;
        public byte PalavraPontuacao { get => _palavraPontuacao; set { _palavraPontuacao = value; OnPropertyChanged("PalavraPontuacao"); } }

        private string _palavra;
        public string Palavra { get => _palavra; set { _palavra = value; OnPropertyChanged("Palavra"); } }

        private string _textoContagem;
        public string TextoContagem { get => _textoContagem; set { _textoContagem = value; OnPropertyChanged("TextoContagem"); } }

        private bool _containerContagem;
        public bool IsVisibleContainerContagem { get => _containerContagem; set { _containerContagem = value; OnPropertyChanged("IsVisibleContainerContagem"); } }

        private bool _containerIniciar;
        public bool IsVisibleContainerIniciar { get => _containerIniciar; set { _containerIniciar = value; OnPropertyChanged("IsVisibleContainerIniciar"); } }

        private bool _btnMostrar;
        public bool IsVisibleBtnMostrar { get => _btnMostrar; set { _btnMostrar = value; OnPropertyChanged("IsVisibleBtnMostrar"); } }

        public Command MostrarPalavra { get; set; }
        public Command Acertou { get; set; }
        public Command Errou { get; set; }
        public Command Iniciar { get; set; }
        
        public JogoViewModel()
        {
            IsVisibleContainerContagem = false;
            IsVisibleContainerIniciar = false;
            IsVisibleBtnMostrar = true;
            Palavra = "***********";

            MostrarPalavra = new Command(MostrarPalavraAction);
            Acertou = new Command(MostrarPalavraAction);
            Errou = new Command(MostrarPalavraAction);
            Iniciar = new Command(MostrarPalavraAction);
        }       

        private void MostrarPalavraAction()
        {
            PalavraPontuacao = 3;
            Palavra = "Levantar";
            IsVisibleBtnMostrar = false;
            IsVisibleContainerIniciar = true;
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
