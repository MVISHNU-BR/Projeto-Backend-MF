using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Backend_MF.Models
{
    [Table("consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a descrição")]
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o valor")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a quilometragem")]
        public int Km { get; set;}

        [Display(Name = "Tipo de combustível")]
        public TipoCombustivel Tipo {  get; set; }

        [Display(Name = "Veículo")]
        [Required(ErrorMessage = "Obrigatório informar a Porra do veículo!")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }
    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol
    }

}
