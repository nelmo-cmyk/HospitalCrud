using System.ComponentModel.DataAnnotations;

namespace HospitalCrud.Models
{
    public class Paciente
    {
        [Key]
        public int idPaciente { get; set; }
        [MaxLength(150)]
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public  string Cpf { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
    }
}
