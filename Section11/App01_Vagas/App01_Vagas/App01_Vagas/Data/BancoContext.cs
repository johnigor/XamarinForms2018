using SQLite;
using Xamarin.Forms;
using App01_Vagas.Models;
using System.Collections.Generic;

namespace App01_Vagas.Data
{
    internal class BancoContext
    {
        private readonly SQLiteConnection _connection;

        public BancoContext()
        {
            var dependencyService = DependencyService.Get<ICaminho>();
            string path = dependencyService.GetPath("Database.Sqlite");
            _connection = new SQLiteConnection(path);
        }

        public List<Vaga> Consultar(Vaga vaga)
        {
            return null;
        }

        public Vaga ObterVagaPorId()
        {
            return null;
        }

        public void Cadastrar(Vaga vaga)
        {

        }

        public void Atualizar(Vaga vaga)
        {

        }

        public void Excluir(int id)
        {

        }
    }
}
