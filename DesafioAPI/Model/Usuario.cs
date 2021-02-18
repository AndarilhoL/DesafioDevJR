using System;

namespace DesafioAPI.Model
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Regras { get; set; }
        public Status Status { get; set; }
    }
}
