using SQLite;
using System.ComponentModel.DataAnnotations;

namespace App01_Vagas.Models
{
    [Table("Vagas")]
    public class Vaga
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Required]
        public string Cargo { get; set; }

        [Required]
        public string Empresa { get; set; }

        [Required]
        public short Quantidade { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public double Salario { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public string TipoContratacao { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
