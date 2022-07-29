using SQLite;
using System.Linq;
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

            _connection.CreateTable<Vaga>();
        }

        public List<Vaga> Consultar(Vaga vaga)
        {
            return _connection.Table<Vaga>().ToList();
        }

        public List<Vaga> PesquisarCargo(string cargo)
        {
            return _connection.Table<Vaga>().Where(x => x.Cargo.Contains(cargo)).ToList();
        }

        public Vaga ObterVagaPorId(int id)
        {
            return _connection.Table<Vaga>().Where(x => x.Id == id).FirstOrDefault();
        }

        public void Cadastrar(Vaga vaga)
        {
            _connection.Insert(vaga);
        }

        public void Atualizar(Vaga vaga)
        {
            _connection.Update(vaga);
        }

        public void Excluir(Vaga vaga)
        {
            _connection.Delete(vaga);
        }
    }
}
