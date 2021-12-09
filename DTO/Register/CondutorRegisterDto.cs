using System;
using System.ComponentModel.DataAnnotations;

namespace DetranApp.DTO
{
    public class CondutorRegisterDto
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string CPF { get; set; }
        public string Telefone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string NumeroCNH { get; set; }
        [Required]
        public DateTime DataNascimento { get; set;}
    }
}