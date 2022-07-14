using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace App02_Tarefa.Modelos
{
    public class GerenciadorTarefa
    {
        private List<Tarefa> _lista { get; set; }
        public void Salvar(Tarefa tarefa)
        {
            _lista = Listagem();
            _lista.Add(tarefa);

            SalvarNoProperties(_lista);
        }
        public void Deletar(int index)
        {
            _lista = Listagem();
            _lista.RemoveAt(index);

            SalvarNoProperties(_lista);

        }
        public void Finalizar(int index, Tarefa tarefa)
        {
            _lista = Listagem();
            _lista.RemoveAt(index);

            tarefa.DataFinalizacao = DateTime.Now;
            _lista.Add(tarefa);
            SalvarNoProperties(_lista);
        }
        public List<Tarefa> Listagem()
        {
            return ListagemNoProperties();
        }
        private void SalvarNoProperties(List<Tarefa> lista)
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                App.Current.Properties.Remove("Tarefas");
            }
            string jsonVal = JsonConvert.SerializeObject(lista);
            App.Current.Properties.Add("Tarefas", jsonVal);
        }
        private List<Tarefa> ListagemNoProperties()
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                string jsonVal = (string)App.Current.Properties["Tarefas"];

                List<Tarefa> lista = JsonConvert.DeserializeObject<List<Tarefa>>(jsonVal);
                return lista;
            }
            return new List<Tarefa>();
        }
    }
}
