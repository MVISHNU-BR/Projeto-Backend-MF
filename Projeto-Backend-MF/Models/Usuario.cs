using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Backend_MF.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informao o nome")]
        public string Nome {  get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar Senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o perfil")]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Àdmin,
        User
    }

}
