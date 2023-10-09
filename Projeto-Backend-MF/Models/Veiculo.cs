using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Backend_MF.Models
{

    [Table("veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Obrigatorio informar nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatorio informar a placa!")]
        public int Placa { get; set;}

        [Required(ErrorMessage = "Obrigatorio informar ano de fabricação")]
        [Display(Name = "Ano de Fabricação")]
        public int AnoFabricação { get; set;}

        [Required(ErrorMessage = "Obrigatorio informar o ano do modelo")]
        [Display(Name = "Ano do Modelo")]
        public int AnoModelo { get; set;}
    }
}
