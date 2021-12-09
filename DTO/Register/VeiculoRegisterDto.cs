using System.ComponentModel.DataAnnotations;

namespace DetranApp.DTO
{
    public class VeiculoRegisterDto
    {
        [Required]
        public string Modelo { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Cor { get; set; }
        [Required]
        public int AnoFabricacao { get; set; }
    }
}