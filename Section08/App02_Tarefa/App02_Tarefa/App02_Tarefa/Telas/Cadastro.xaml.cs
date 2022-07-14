using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_Tarefa.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cadastro : ContentPage
    {
        public Cadastro()
        {
            InitializeComponent();
        }
        public void PrioridadeSelectAction(object sender, EventArgs args)
        {
            var stacks = SL_Prioridades.Children;

            foreach (var linha in stacks)
            {
                Label LblPrioridade = ((StackLayout)linha).Children[1] as Label;
                LblPrioridade.TextColor = Color.Gray;
            }

            ((Label)((StackLayout)sender).Children[1]).TextColor = Color.Black;
            FileImageSource source = ((Image)((StackLayout)sender).Children[0]).Source as FileImageSource;
            String prioridade = TxtNome.Text = source.File.ToString().Replace("Resources/", "").Replace(".png", "");
            TxtNome.Text = prioridade;
        }
    }
}
