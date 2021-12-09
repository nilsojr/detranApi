using System;

namespace DetranApp.Models
{
    public class VeiculoCondutor
    {
        public Veiculo Veiculo { get; set; }
        public Condutor Condutor { get; set; }
        public DateTime DataTransacao { get; set; }
    }
}