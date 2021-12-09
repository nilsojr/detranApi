using System;

namespace DetranApp.Models
{
    public class Condutor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string NumeroCNH { get; set; }
        public DateTime DataNascimento { get; set;}
    }
}