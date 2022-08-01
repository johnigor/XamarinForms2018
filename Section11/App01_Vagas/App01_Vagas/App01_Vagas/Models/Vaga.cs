using SQLite;
using System.Collections.Generic;

namespace App01_Vagas.Models
{
    [Table("Vagas")]
    public class Vaga
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Cargo { get; set; }
        public string Empresa { get; set; }
        public short Quantidade { get; set; }
        public string Cidade { get; set; }
        public double Salario { get; set; }
        public string Descricao { get; set; }
        public string TipoContratacao { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
