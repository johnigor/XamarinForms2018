using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchBarPage : ContentPage
    {
        private List<string> _empresasTI;
        public SearchBarPage()
        {
            InitializeComponent();

            _empresasTI = new List<string>();
            _empresasTI.Add("Microsoft");
            _empresasTI.Add("Apple");
            _empresasTI.Add("Oracle");
            _empresasTI.Add("IBM");
            _empresasTI.Add("SAP");
            _empresasTI.Add("Uber");
            _empresasTI.Add("IFood");

            Preencher(_empresasTI);
        }

        private void PesquisarButton(object sender, EventArgs args)
        {
            var resultado = _empresasTI.Where(x => x.Contains(((SearchBar)sender).Text)).ToList<String>();
            Preencher(resultado);
        }

        private void Pesquisar(object sender, TextChangedEventArgs args)
        {
            var resultado =_empresasTI.Where(x => x.ToUpper().Contains(args.NewTextValue.ToUpper())).ToList<String>();
            Preencher(resultado);
        }
        private void Preencher(List<string> empresasTI)
        {
            ListResult.Children.Clear();
            foreach (var emp in empresasTI)
            {
                ListResult.Children.Add(new Label { Text = emp });
            }
        }

        private void Pesquisar(object sender, EventArgs e)
        {

        }
    }
}